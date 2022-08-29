using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 0f;
    // Update is called once per frame
    void Update()
    {
        if (time > 0f){
        // Subtract the difference of the last time the method has been called
        time -= Time.deltaTime;
    }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && time <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // New time variable stored, after dog Prefab has been instantiated.
            time = 1f;   
        }
    }
}




