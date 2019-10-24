using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private bool GrabObject = false;
    private string InteractText;
    public AudioSource SeedColledted;

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag =="tools")
        {

            //Destroy(col.collider.gameObject);
            Debug.Log("aaaaa");            
        }
        if (col.collider.tag == "seed")
        {
            Achievment.ach01Count += 1;
            Destroy(col.collider.gameObject);
            Debug.Log("bbbb");
            SeedColledted.Play();

        }

    }

   
    //public void OnInteract()
    //{
    //    InteractText = "Press F to ";
    //
    //    GrabObject = !GrabObject;
    //    InteractText += GrabObject ? "Use" : "Drop";
    //
    // }

    void Update()
    {
    }
     
    

}
