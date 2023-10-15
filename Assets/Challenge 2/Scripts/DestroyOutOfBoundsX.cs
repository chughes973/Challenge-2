using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -35; //limit to dog leaving screen
    private float bottomLimit = 0; //limit to ball below ground

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit) // changed > to < so that dog is destroy when too far
        {
            Destroy(gameObject);
            
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit) // changes z to y so that ball is destroyed when below y position 0
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }

    }
}
