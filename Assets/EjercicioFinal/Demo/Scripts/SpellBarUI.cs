using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBarUI : MonoBehaviour
{
    public List<SpellSlot> slots; // Assigned in inspector or dynamically
    private int selectedIndex = 0;
    public void SetSelectedIndex(int index)
    {
        if (index < 0 || index >= slots.Count) return;

        selectedIndex = index;
        UpdateSelectionHighlight();
    }
    private void UpdateSelectionHighlight()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            slots[i].SetHighlight(i == selectedIndex);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) SetSelectedIndex((selectedIndex + 1) % slots.Count);
    }
}
