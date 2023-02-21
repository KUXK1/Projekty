using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koniecmisji : MonoBehaviour
{
    public GameObject obiec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        obiec.SetActive(true);
    }
} 
