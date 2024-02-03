using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public int health;
    public float speed;
    public Rigidbody2D knightRb;
    public BoxCollider2D knightBc;
    public BoxCollider2D leftTowerBc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (health != 0)
        {
            knightRb.velocity += Time.deltaTime * Vector2.left * speed;
            health--;
        }

    }

    private void OnCollisionEnter2d(Collision collision)
    {
        health = 0;
    }
}
