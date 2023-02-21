using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruszanie : MonoBehaviour
{
    public CharacterController kontroler;
    public float szybkosc = 12f;
    Vector3 spadek;
    public float grawitacja= - 10f;
    public Transform sprawdza;
    public float ziemia = 0.4f;
    public LayerMask ziemiaobj;
    bool zaziemiony;
    public float skok = 0.1f;

    





  
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
        zaziemiony = Physics.CheckSphere(sprawdza.position, ziemia, ziemiaobj);
        if(zaziemiony && spadek.y < 0) 
        {
            spadek.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 ruch = transform.right * x + transform.forward * z;
        kontroler.Move(ruch * szybkosc * Time.deltaTime);

        spadek.y += grawitacja * Time.deltaTime;

        kontroler.Move(spadek * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && zaziemiony)
        {
            spadek.y = Mathf.Sqrt(skok) * -2f * grawitacja;
        }
        if (zaziemiony == false)
        {
            
            Time.timeScale = 0.7f;
        }
        if (zaziemiony == true)
        {

            Time.timeScale = 1;
        }

      









    }
}
