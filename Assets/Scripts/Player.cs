using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Rigidbody2D rb;
    public bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Andar
         moveH = Input.GetAxis("Horizontal");
         transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);

         //Pular
         if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
         {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
         }

    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }
    }
} 
