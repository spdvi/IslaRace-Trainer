using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
        //transform.Rotate(Vector3.up, 1, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
