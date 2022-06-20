using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher_Rotator : MonoBehaviour
{
   
    void Update()
    {
        RotateWithMouse();

    }

    /// <summary>
    /// Rotates the object  based on the mouse position
    /// </summary>
    void RotateWithMouse()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }


}




