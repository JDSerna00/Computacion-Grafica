using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MagicSkill : ScriptableObject
{
    public string effectName;
    public abstract void PlayEffect(GameObject caster);
}
