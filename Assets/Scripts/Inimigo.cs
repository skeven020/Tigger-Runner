using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inimigo : MonoBehaviour

{

public float speed;
public Rigidbody2D enemyRb;
bool faceFlip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }

    void flipEnemy()
    {
        if(faceFlip)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }  
 void OnCollisionEnter2D(Collision2D col)
    {
    if(col != null && !col.collider.CompareTag("Player") && !col.collider.CompareTag("Chão"))
    {
        faceFlip = !faceFlip;
    }
        flipEnemy();
    }

}