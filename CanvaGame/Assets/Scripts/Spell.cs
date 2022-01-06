using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Spell : MonoBehaviour
{
    [SerializeField] protected Button _spellButton;
    [SerializeField] protected int _damage;
    [SerializeField] protected Player _target;
}
