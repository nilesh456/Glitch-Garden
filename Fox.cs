using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Attack))]
public class Fox : MonoBehaviour {

    private Animator anim;
    private Attack attack;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        attack = GetComponent<Attack>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;

        if (!obj.GetComponent<Defender>())
        {
            return;
        }

        

        if (obj.GetComponent<Stone>())
        {
            anim.SetTrigger("JumpTrigger");
        }
        else
        {
            anim.SetBool("IsAttacking", true);
            attack.Attck(obj);
        }
    }
}
