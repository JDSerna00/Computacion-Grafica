using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class SpellSlot : MonoBehaviour
{
    public Image background; // Highlight
    public Image icon;       // Icon

    public void SetHighlight(bool active)
    {
        background.enabled = active;
    }
}
