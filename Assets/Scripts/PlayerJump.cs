using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 4f;
    private Rigidbody rb;
    private float fallMultiplier = 2.5f;
	private float lowJumpMultiplier = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 0.75)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        //if (rb.velocity.y < 0)
        //{
        //    rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        //}
		//else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
		//{
		//	rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		//}
    }
}
