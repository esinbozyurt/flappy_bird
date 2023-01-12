using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 2f;
    private Rigidbody2D rigidbody;
   

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.velocity = Vector2.up * velocity;
            //transform.eulerAngles = new Vector3(transform eulerAngles.x, transform eulerAngles.y, transform eulerAngles.60.0f);
        }
    }
    
    public GameManager gameManager;
    public bool isDead = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        gameManager.GameOver();
    }
    
}