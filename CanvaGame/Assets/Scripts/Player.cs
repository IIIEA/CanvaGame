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

    public void ChangeHealthValue(float value)
    {
        _health += value;

        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        else if(_health < 0)
        {
            _health = _maxHealth;
        }
    }
}
