using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject WoWVFX;
    [SerializeField] Transform targetPos;
    private void Awake()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
    }

    private void Cast()
    {
        Instantiate(WoWVFX, targetPos.position, Quaternion.identity);
        Debug.Log("Casting the spell");
    }
}
