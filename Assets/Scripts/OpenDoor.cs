using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool isDoorLocked = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDoorLocked && transform.position.y < 5.5f)
        {
            // Move the door up 5m - animated
            transform.Translate(0, 0.2f * Time.deltaTime, 0);
        }
    }
}
