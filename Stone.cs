using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D (Collider2D collider)
    {
        Attack attack = collider.gameObject.GetComponent<Attack>();
        if (attack)
        {
            animator.SetTrigger("IsAttacking");
        }
       
    }
}
