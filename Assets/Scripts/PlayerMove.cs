using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float hInput;
    private float vInput;
    public float moveSpeed = 2.0f;
    public float rotateSpeed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player ready to rock & roll!");
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //transform.Translate((Vector3.forward * vInput + Vector3.right * hInput) * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * vInput * Time.deltaTime * moveSpeed);
        transform.Rotate(Vector3.up * hInput * Time.deltaTime * rotateSpeed);

    }
}
