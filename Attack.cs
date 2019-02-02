using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class Attack : MonoBehaviour {

    [Tooltip ("Average number of times attackers are seen")]
    public float seenPerSeconds;

    private float currentSpeed;
    private GameObject currentTargert;
    private Animator animator;

	// Use this for initialization
	void Start () {
        // Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
        // myRigidbody.isKinematic = true;
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTargert)
        {
            animator.SetBool("IsAttacking", false);
        }
	}

    void OnTriggerEnter2D()
    {
        
    }

    public void SetSpeed (float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget (float damage)
    {
        if (currentTargert)
        {
            Health health = currentTargert.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(damage);
            }

        }
    }

    public void Attck (GameObject obj)
    {
        currentTargert = obj;
    }
}
