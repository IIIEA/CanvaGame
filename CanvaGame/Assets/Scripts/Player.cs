using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _maxHealth;

    public event UnityAction HealthChanged;

    public int Health => _health;

    private void Awake()
    {
        _maxHealth = _health;
    }

    private void OnValidate()
    {
        if (_health < 0)
            _health = 0;
    }

    public void ApplyDamage(int value)
    {
        _health -= value;
        HealthChanged?.Invoke();

        if (_health <= 0)
            Destroy(gameObject);

        if (_health > _maxHealth)
            _health = _maxHealth;
    }
}
