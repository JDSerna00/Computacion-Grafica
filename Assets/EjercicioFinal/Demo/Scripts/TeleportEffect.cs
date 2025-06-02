using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Magic/TeleportEffect")]
public class TeleportEffect : MagicSkill
{
    public Material dissolveMaterial;
    public GameObject teleportEffectPrefab;
    public float dissolveSpeed = 0.1f;
    public Vector3 targetOffset;

    public override void PlayEffect(GameObject caster)
    {
        caster.GetComponent<MonoBehaviour>().StartCoroutine(DissolveAndTeleport(caster));
    }

    private IEnumerator DissolveAndTeleport(GameObject caster)
    {
        float dissolveAmount = 1f;
        if(teleportEffectPrefab != null)
        {
            GameObject effectInstance = Instantiate(teleportEffectPrefab, caster.transform.position, Quaternion.identity);
            Destroy(effectInstance, 2f); // Destroy the effect after 2 seconds
        }


        while (dissolveAmount > -1f)
        {
            dissolveAmount -= Time.deltaTime * dissolveSpeed;
            dissolveMaterial.SetFloat("_Dissolve_Amount", dissolveAmount);
            Debug.Log($"Restoring: {dissolveAmount}");
            yield return null;
        }
        caster.transform.position += targetOffset;
        while(dissolveAmount < 1f)
        {
            dissolveAmount += Time.deltaTime * dissolveSpeed;
            dissolveMaterial.SetFloat("_Dissolve_Amount", dissolveAmount);
            Debug.Log($"Dissolving: {dissolveAmount}");
            yield return null;
        }
    }


}
