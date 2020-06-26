using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class StartImpulse : MonoBehaviour
{

    public float force = 1000f; 
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        //multiplier le vecteur de l'avant (qui traverse l'objet pas le monde) par une force donc un nombre
        // le vecteur de base commence à 1 (1 unité vers l'avant)
        // donc on l'allonge en le multipliant. (ici par 1000)
        rb.AddForce(transform.forward * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
