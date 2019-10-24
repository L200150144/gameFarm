using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievment : MonoBehaviour
{
    //Global variable
    public GameObject achNote; //latar belakang panel achievement
    public AudioSource achSound; //suara achievement
    public bool achActive = false;    //bolean status panel
    public GameObject achTitle;     // judul panel (text)
    public GameObject achDesc;      // descripsi (panel)

    //01 achievement variable
    public GameObject ach01Image;       // gambar spesifik di setiap achievment
    public static int ach01Count;       // jumlah barang yang didapat
    //public int ach01Trigger = 5;        // 
    public int ach01Code;   //nilai untuk transit
        
    void Update()
    {
        Debug.Log(ach01Count);
        ach01Code = PlayerPrefs.GetInt("ach01");
        
        if (ach01Count == 5)
        {
            Debug.Log("fishon");
            StartCoroutine(Trigger01Ach());
            ach01Count = ach01Count + 1;
        }
                                
    }
    
      IEnumerator Trigger01Ach()
    {
        Debug.Log("Triggerin");
        //achSound.Play();
        achActive = true;
        ach01Code = 12345;
        PlayerPrefs.SetInt("Ach01", ach01Code);
        ach01Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "COLLECTION";
        achDesc.GetComponent<Text>().text = "Great You Find 5 Corns";
        achNote.SetActive(true);
        yield return new WaitForSeconds(3);

        //resetUI
        
        ach01Image.SetActive(false);
        achNote.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
        
    }

    
}
