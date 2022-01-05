using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _minSliderValue = 0;

    private const float _delayToFill = 0.5f;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = _minSliderValue;
        _slider.maxValue = _player.Health;
    }

    private void Start()
    {
        _slider.value = _player.Health;
    }

    public void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged()
    {
        _slider.DOValue(_player.Health, _delayToFill);
    }
}
