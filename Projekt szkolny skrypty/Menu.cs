using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu : MonoBehaviour
{
    public GameObject ZMIENA;
    public GameObject Ustawienia;
    float switchs;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        ZMIENA.SetActive(false);
        switchs = 0;
    } 

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            ZMIENA.SetActive(true);
        }
        

    }
   
   
     public void closemenu()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        switchs = 0;
        ZMIENA.SetActive(false);
    }
    public void exitgame()
    {
        Application.Quit();
    }
    public void ustawieniaon()
    {
        Ustawienia.SetActive(true);
        ZMIENA.SetActive(false);
    }
    public void ustawieniaoff()
    {
        Ustawienia.SetActive(false);
        ZMIENA.SetActive(true);
    }

}
