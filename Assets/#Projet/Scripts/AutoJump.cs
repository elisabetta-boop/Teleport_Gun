using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJump : MonoBehaviour
{
    
    Rigidbody rb;
    public Vector3 verticalForce;
    public Vector3 additionalForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity == Vector3.zero)
        {
            rb.AddForce(verticalForce);
            Debug.Log("ciao");
            verticalForce += additionalForce;
        }
        //si la velocity de rigid body est à Vector3.zero (immobile)
        //lui donner une force vers le haut (rb.AddForce(force))
        //augmenter la verticalForce de additionalForce pour la prochaine fois

    }
}
