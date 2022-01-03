using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _maxHealth;

    public float Health => _health;

    private void Awake()
    {
        _maxHealth = _health;
    }

    private void OnValidate()
    {
        if (_health < 0)
            _health = 0;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;

        if(_health < 0)
        {
            _health = 0;
        }
    }

    public void TakeHealth(float heal)
    {
        _health += heal;

        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
    }
}
