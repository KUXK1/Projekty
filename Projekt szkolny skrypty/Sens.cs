using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sens : MonoBehaviour
{
    public float Speed = -0.5f;
    private float x;
    private float y;
    private Vector3 rotateValue;
    public Slider sens;

    void Update()
    {

        x = Input.GetAxis("Mouse X");

        //Speed = Speed * sens.value;
        rotateValue = new Vector3(0, x * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
        transform.eulerAngles += rotateValue * sens.value;
    }
}
