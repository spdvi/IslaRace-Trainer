using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInside : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.name);
    }
}
