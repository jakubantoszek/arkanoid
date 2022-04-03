using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBottom : MonoBehaviour
{
    public BallScript bs;
    public GameController gc;

    void OnTriggerEnter(Collider col)
    {
        bs.lives--;
        if(bs.lives > 0)
            Debug.Log("Number of lives : " + bs.lives);
        else Debug.Log("Number of lives : " + bs.lives + ". You lose the game.");
        gc.Reset();
    }
}
