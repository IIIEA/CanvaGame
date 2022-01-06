using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpell : Spell
{
    private void OnEnable()
    {
        _spellButton.onClick.AddListener(OnSpellCast);
    }

    private void OnDisable()
    {
        _spellButton.onClick.RemoveListener(OnSpellCast);
    }

    private void OnSpellCast()
    {
        _target.ApplyDamage(_damage);
    }
}
