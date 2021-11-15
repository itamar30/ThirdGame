using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{


    public float cameraSpeed;

    
    void Update()
    {
        //changing camera position every frame according 
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
