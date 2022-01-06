using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    public event UnityAction<int,int> HealthChanged;

    public int Health => _maxHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }

    private void OnValidate()
    {
        if (_maxHealth < 0)
            _maxHealth = 0;
    }

    public void ApplyDamage(int value)
    {
        if (_currentHealth - value <= 0)
        {
            _currentHealth = 0;
            Destroy(gameObject);
        }
        else
        {
            _currentHealth -= value;
        }

        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }

    public void TakeHeal(int heal)
    {
        if (_currentHealth + heal >= _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
        else
        {
            _currentHealth += heal;
        }

        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}
