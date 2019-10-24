using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collected : MonoBehaviour
{
    public AudioSource CollectSound;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaa");
        Achievment.ach01Count += 1;
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("bbbb");
        }
        CollectSound.Play();
    }
}
