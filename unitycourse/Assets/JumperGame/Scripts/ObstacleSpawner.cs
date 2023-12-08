using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObstacle", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiateObstacle()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity, this.transform);
    }
}
