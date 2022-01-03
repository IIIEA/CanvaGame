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

    private const float _delayToFill = 0.3f;

    private void OnValidate()
    {
        if(_minSliderValue >= _player.Health)
        {
            _minSliderValue = _player.Health - 1;
        }
    }

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

    public void SetSliderValue()
    {
        _slider.DOValue(_player.Health, _delayToFill);
    }
}
