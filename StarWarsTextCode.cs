using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWarsIntro : MonoBehaviour
{



    public float scrollSpeed = 20;
 
    // Update is called once per frame
    void Update()
    {
        //Get current position of parent GameObject
        Vector3 pos = transform.position;

        // Get Vector poiting into the distance
        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

        // Move the text object into the distance to give our 3D scrolling effect
        pos += localVectorUp * scrollSpeed * Time.deltaTime;
        transform.position = pos;

        
    }
}
