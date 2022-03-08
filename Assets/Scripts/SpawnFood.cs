using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    int maxX = 6;
    int yPos = 6;
    int maxZ = 6;
    public int forceModule = 10;
    int randomSeconds = 2;
    int minRandomSeconds = 1;
    int maxRandomSeconds = 4;
    float timeAtStartOfNewPeriod;

    // Cached references
    public GameObject[] foodPrefabs;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -2f, 0);
        timeAtStartOfNewPeriod = Time.realtimeSinceStartup;
        randomSeconds = Random.Range(minRandomSeconds, maxRandomSeconds);
        
    }

    void InstantiateFood()
    {
        int xPos = Random.Range(-maxX, maxX);
        int zPos = Random.Range(-maxZ, maxZ);
        Vector3 initialFoodPoint = new Vector3(xPos, yPos, zPos);
        int randomItemIndex = Random.Range(0, foodPrefabs.Length - 1);
        GameObject item = Instantiate(foodPrefabs[randomItemIndex], initialFoodPoint, Quaternion.identity);
        Vector3 forceDirection = player.transform.position - initialFoodPoint;
        item.GetComponent<Rigidbody>().AddForce(forceDirection * forceModule, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time - timeAtStartOfNewPeriod;
        if (Mathf.FloorToInt(elapsedTime) > randomSeconds)
        {
            InstantiateFood();
            timeAtStartOfNewPeriod = Time.realtimeSinceStartup;
            randomSeconds = Random.Range(minRandomSeconds, maxRandomSeconds);
        }
    }
}
