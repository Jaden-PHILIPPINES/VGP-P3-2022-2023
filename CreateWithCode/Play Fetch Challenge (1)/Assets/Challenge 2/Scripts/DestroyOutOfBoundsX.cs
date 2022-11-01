using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftBound = -30;
    private float lowerBound = -5;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than leftBound
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than lowerBound
        else if (transform.position.y < lowerBound)
        {
        Debug.Log("skill issue!");
        Destroy(gameObject);
        }
    }
}
