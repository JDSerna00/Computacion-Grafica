using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    public MagicSkill[] magicEffects;
    private int currentIndex = 0;


    private float dissolveAmount = 0f;
    private bool isCasting = false;
    private void Awake()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }
    public void NextEffect()
    {
        currentIndex = (currentIndex + 1) % magicEffects.Length;
        Debug.Log("Switched to: " + magicEffects[currentIndex].effectName);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            NextEffect();
        }
    }

    private void Cast()
    {
        if (magicEffects.Length == 0) return;
        magicEffects[currentIndex].PlayEffect(gameObject);
    }

    
}
