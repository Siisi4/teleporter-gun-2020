using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescuePlayer : MonoBehaviour
{

    private GameObject player;
    private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        originalPosition = player.transform.position;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CharacterController cc = player.GetComponent<CharacterController>();

            cc.enabled = false;
            player.transform.position = originalPosition;
            cc.enabled = true;
        }
    }

}
