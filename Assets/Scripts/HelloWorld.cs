using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string textToPrint = "Hello World";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(textToPrint);
    }
}
