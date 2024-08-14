using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float sensetivy = 150f;
    float rotateZone = Screen.width / 5;

    void Update()
    {
        if (Input.mousePosition.x < rotateZone && transform.rotation.eulerAngles.y > 20)
        {
            transform.Rotate(0, -sensetivy * Time.deltaTime, 0);
        }
        if (Input.mousePosition.x > Screen.width - rotateZone && transform.rotation.eulerAngles.y < 160)
        {
            transform.Rotate(0, sensetivy * Time.deltaTime, 0);
        }



    }
       
    
}
