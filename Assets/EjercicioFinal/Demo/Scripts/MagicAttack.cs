using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Magic/MagicAttackEffect")]
public class MagicSpell : MagicSkill
{
    public GameObject effectPrefab;
    public Vector3 spawnOffset = Vector3.forward;

    public override void PlayEffect(GameObject caster)
    {
        Vector3 spawnPos = caster.transform.position + caster.transform.TransformDirection(spawnOffset);
        GameObject effectInstance = Instantiate(effectPrefab, spawnPos, Quaternion.identity);
        Destroy(effectInstance, 6f); // Destroy the effect after 2 seconds
    }

}
