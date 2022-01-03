using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationSetter : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string takeDamage = nameof(takeDamage);
    private const string takeHeal = nameof(takeHeal);

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void TakeDamage()
    {
        _animator.SetTrigger(takeDamage);
    }

    public void TakeHeal()
    {
        _animator.SetTrigger(takeHeal);
    }
}
