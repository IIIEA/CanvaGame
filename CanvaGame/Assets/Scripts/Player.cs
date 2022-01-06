using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _currentHealth;

    public event UnityAction<int,int> HealthChanged;

    public int Health => _health;

    private void Start()
    {
        _currentHealth = _health;
    }

    private void OnValidate()
    {
        if (_health < 0)
            _health = 0;
    }

    public void ApplyDamage(int value)
    {
        _currentHealth -= value;
        HealthChanged?.Invoke(_currentHealth, _health);

        if (_currentHealth <= 0)
            Destroy(gameObject);
    }

    public void TakeHeal(int heal)
    {
        _currentHealth += heal;
        HealthChanged?.Invoke(_currentHealth, _health);

        if (_currentHealth >= _health)
            _currentHealth = _health;
    }
}
