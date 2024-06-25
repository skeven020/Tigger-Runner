using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animation animPlayer;
    public bool GameOver;
    // Start is called before the first frame update
    void Start()
    {
       animPlayer = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            animPlayer.SetLayerWheight(2, 1);
        }
        else 
        {
            animPlayer.SetLayerWheight(2, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animPlayer.SetLayerWheight(1, 1);
        }
        else
        {
            animPlayer.SetLayerWheight(1, 0);
        }
    }
}
