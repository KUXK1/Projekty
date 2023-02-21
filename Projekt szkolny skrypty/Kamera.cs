using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public float camSpeed = -0.5f;
    private float x;
    private float y;
    private Vector3 rotateValue;

    void Start()
    {
       
    }
    void Update()
    {
        
        y = Input.GetAxis("Mouse Y");
     
        rotateValue = new Vector3(y, 0, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
        transform.eulerAngles += rotateValue * camSpeed;
    }
}
