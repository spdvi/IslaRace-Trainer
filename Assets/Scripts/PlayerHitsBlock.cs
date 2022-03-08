using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitsBlock : MonoBehaviour
{
    OpenDoor openDoorScript;

    // Start is called before the first frame update
    void Start()
    {
        openDoorScript = FindObjectOfType<OpenDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            openDoorScript.isDoorLocked = false;
        }
    }
}
