using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public BallScript bs;
    public PaddleController pc;
    public bool stopped = false;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if(stopped && Input.GetKey(KeyCode.Space) && (bs.lives > 0))
        {
            stopped = false;
            bs.GetComponent<Rigidbody>().AddRelativeForce(0, -400, 0);
        }
    }

    public void Reset()
    {
        stopped = true;
        bs.StartPosition();
        pc.StartPosition();
    }
}
