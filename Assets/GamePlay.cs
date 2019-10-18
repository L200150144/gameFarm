using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public Transform player;
    public Transform Playercam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;

    public AudioClip[] soundToPlay;
    private AudioSource audio;
    private bool touched = false;

    void start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
               

        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetButtonDown("use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = Playercam;
            beingCarried = true;
        } 
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if(Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(Playercam.forward * throwForce);
            //RandomAudio();

            }
            else if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                beingCarried = false;
            }
        }
        
    }

    void RandomAudio()
    {
        if (audio.isPlaying)
        {
            return;
        }
        audio.clip = soundToPlay[Random.Range(0, soundToPlay.Length)];
        audio.Play();
    }
    void OnTriggerEnter(Collider other)
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
    void movement()
    {
        //movement
        float speed = 10f;
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }

        bool isIdle = moveX == 0 && moveY == 0;
        if (isIdle)
        {

        }
        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        transform.position += moveDir * speed * Time.deltaTime;
    }
}
