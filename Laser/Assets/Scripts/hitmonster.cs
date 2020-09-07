using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitmonster : MonoBehaviour
{
    [Tooltip("Raycast range")]
    public float r = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Color color = Color.blue;
            if (hit.transform.tag == "Monster")
            {
                color = Color.magenta;
                Debug.Log("Il y a un monstre ici");
            }
            Debug.DrawRay(transform.position, transform.forward * r, color);
        }
    }
}

