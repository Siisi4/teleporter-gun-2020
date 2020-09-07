using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    // notes pour moi //
    [Tooltip("Raycast range")]
    public float r = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.forward;


        RaycastHit hit;
        Debug.DrawRay(transform.position, fwd * r, Color.red) ;
        if (Physics.Raycast(transform.position, fwd, out hit))
        {  
            Debug.DrawRay(transform.position,fwd * r, Color.green);
            Debug.Log("Tu touches quelque chose à " + hit.distance);
        }
        
    }
}
