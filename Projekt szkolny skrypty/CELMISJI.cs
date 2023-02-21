using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CELMISJI : MonoBehaviour
{
    public GameObject obiektmisji;
    public GameObject koniecs;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        obiektmisji.SetActive(false);
        koniecs.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
