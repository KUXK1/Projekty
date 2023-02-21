using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuszanieKam : MonoBehaviour
{
    public float sesns = 100f;
    public Transform player;
    float rotx = 0f;
    float roty = 0f;
    public Transform p2;
    void Start()
    {
        
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * 1 * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sesns * Time.deltaTime;
        rotx -= mouseY;
        rotx = Mathf.Clamp(rotx, -90f, 90f);
        roty += mouseX;

        transform.localRotation = Quaternion.Euler(rotx, roty,0f);
        
       
    }
}
