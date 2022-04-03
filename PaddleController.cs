using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float paddleMoveSpeed = 0.1F;
    public float paddleRotateSpeed = 1.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(paddleMoveSpeed, 0, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-paddleMoveSpeed, 0, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, paddleRotateSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -paddleRotateSpeed, Space.World);
        }
    }

    public void StartPosition()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
