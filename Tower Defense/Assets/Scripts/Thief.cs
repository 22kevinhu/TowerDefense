using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    public Rigidbody2D thiefRb;
    public float speed;
    public int health;

   void FixedUpdate() 
    {
        while (health != 0) {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }

    }
}