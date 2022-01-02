using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Slider))]
public class Button : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private readonly float _changeValue = 0.1f;
    private readonly float _minSliderValue = 0;
    private readonly float _maxSliderValue = 1;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void TakeHeal()
    {
        _slider.DOValue(_slider.value + Mathf.MoveTowards(_minSliderValue, _maxSliderValue, _changeValue), 0.3f);
    }

    public void TakeDamage()
    {
        _slider.DOValue(_slider.value - Mathf.MoveTowards(_minSliderValue, _maxSliderValue, _changeValue), 0.3f);
    }
}
