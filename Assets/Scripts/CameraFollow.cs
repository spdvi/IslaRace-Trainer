using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
    }

    private void LateUpdate()
    {
        // Solves jittering problem
        transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;
        //transform.position = player.transform.TransformPoint(offset);
        //transform.LookAt(player.transform);
    }
}
