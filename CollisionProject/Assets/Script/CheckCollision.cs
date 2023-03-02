using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    Vector3 startPosition;
    


   
    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Obstacles")
        {
            print("Bateu BURRO!!!");
            transform.position = startPosition;
        }
    }
}
