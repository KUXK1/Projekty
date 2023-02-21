using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistolet : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 10000f;
    public float dmg = 10f;
    public float range = 100f;
    public float szybkosc = 15f;
    public Camera fps;
    public ParticleSystem efekt;
    public float czasodnowienia;
    public GameObject inpact;
    public GameObject krew;
   
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            efekt.Stop();
        }
        if (Input.GetKey(KeyCode.Mouse0) &&  Time.time >= czasodnowienia)
        {
            
            czasodnowienia = Time.time + 1f / szybkosc;
            
            strzal();
        }
        
        void strzal()
        {
            
            efekt.Play();
      
            

            
            RaycastHit hit;
            if (Physics.Raycast(fps.transform.position, fps.transform.forward, out hit, range))
            {
                
                Debug.Log(hit.transform.name);
                cel target = hit.transform.GetComponent<cel>();
                if( target != null)
                {
                    target.takedmg(dmg);
                    Instantiate(krew, hit.point, Quaternion.LookRotation(hit.normal));
                }
                else
                {
                    Instantiate(inpact, hit.point, Quaternion.LookRotation(hit.normal));
                }

                
            }
        }
    }
}
