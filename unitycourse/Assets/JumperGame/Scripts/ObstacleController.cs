using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    JumperController jumperController;
    // Start is called before the first frame update
    void Start()
    {
        jumperController = FindObjectOfType<JumperController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!jumperController.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 15);
        }   
    }
}
