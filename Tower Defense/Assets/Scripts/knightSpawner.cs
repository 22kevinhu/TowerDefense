using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightSpawner : MonoBehaviour
{
    public GameObject Knight; 
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(Knight);
        }
    }
}
