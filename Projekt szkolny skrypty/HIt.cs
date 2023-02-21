using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HIt : MonoBehaviour
{
    public GameObject postac;
    public Text tekst;
    public CapsuleCollider gracz;
    public LayerMask pocisk;
    public float hp;
    public string hhh;
    public GameObject over;
    
    private void Start()
    {
        over.SetActive(false);
    }
    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "pocisk")
        {
            hp = hp - 20;
        }
    }
    private void Update()
    {
        
        
        hhh = hp.ToString();
        tekst.text = hhh;
        if (hp< 100)
        {
            hp =hp+ 0.005f;
        }
        if (hp < 0)
        {
            Debug.Log("dead");
            over.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
