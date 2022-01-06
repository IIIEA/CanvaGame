using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Bar : MonoBehaviour
{
    [SerializeField]protected Slider _slider;

    private float _delayToFill = 0.5f;

    protected void OnHealthChanged(int value, int maxValue)
    {
        if (maxValue != 0)
            _slider.DOValue((float)value / maxValue, _delayToFill);
    }
}
