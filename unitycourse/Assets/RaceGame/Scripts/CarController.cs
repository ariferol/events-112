using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public Camera mainCamera;
    public float speed = 10f;
    public float rotSpeed = 45f;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("baþladý");
    }

    // Update is called once per frame
    void Update()
    {
        StraightMovement();
        ChangeRotation();
    }

    private void StraightMovement()
    {
        #region this.gameobject

        //transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * 10);
        /*this.gameObject.*/
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        #endregion
    }

    private void ChangeRotation()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * horizontalInput * rotSpeed * Time.deltaTime);
    }


}
