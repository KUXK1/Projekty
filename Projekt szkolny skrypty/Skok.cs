using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skok : MonoBehaviour
{
    Animator animacja;
    // Start is called before the first frame update
    void Start()
    {
        animacja = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animacja.SetFloat("x", Input.GetAxis("Horizontal"));
        animacja.SetFloat("y", Input.GetAxis("Vertical"));
        if (Input.GetKeyUp(KeyCode.Space))
        {
            skok();
        }
    }
    public void skok()
    {
        animacja.SetTrigger("jump");
    }
}
