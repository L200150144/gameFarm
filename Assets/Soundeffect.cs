using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffect : MonoBehaviour
{
    public AudioSource click;
    public AudioSource back;
    public AudioSource confirm;

    public void PlayClick()
    {
        click.Play();
       
        IEnumerator Example()
        {
            print(Time.time);
            yield return new WaitForSeconds(5);
            print(Time.time);
        }
    }
    public void PlayBack()
    {
        back.Play();
    }
    public void PlayConfirm()
    {
        confirm.Play();
    }
}
