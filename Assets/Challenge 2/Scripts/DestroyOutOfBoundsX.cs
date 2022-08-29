using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -43;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit or destroy balls if y position is less than bottomLimit
        if (transform.position.x < leftLimit || transform.position.y < bottomLimit )
        {
            Destroy(gameObject);
        } 
    }
}
