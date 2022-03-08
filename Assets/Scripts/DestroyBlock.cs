using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    public GameObject blockPrefab;
    // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);

    // Start is called before the first frame update
    void Start()
    {
        //blockPrefab = Fin
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(this.gameObject.name + " collided with " + collision.gameObject.name);
        //Destroy(gameObject);

        //int randomX = Random.Range(-4, 4);
        //int randomY = Random.Range(2, 6);
        //int randomZ = Random.Range(-4, 4);
        //Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);
        //Instantiate(blockPrefab, randomPosition, transform.rotation);
    }
}
