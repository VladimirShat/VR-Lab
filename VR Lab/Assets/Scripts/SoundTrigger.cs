using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource audioSrc;
    bool playerInside;
    public float volume = 0f;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInside = true;
            StartCoroutine("IncreaseSoundFromZeroToHalf");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInside = false;
            StartCoroutine("DecreasSoundFromHalfToZero");
        }
    }

    IEnumerator IncreaseSoundFromZeroToHalf()
    {
        volume = 0f;
        float acceleration = 0.005f;

        while (audioSrc.volume < 0.5f && playerInside)
        {
            volume = volume + acceleration;
            audioSrc.volume += volume;
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator DecreasSoundFromHalfToZero()
    {
        //float volume = 0.06f;
        float acceleration = 0.0005f;

        while (audioSrc.volume > 0f && !playerInside)
        {
            if (volume - acceleration > 0.01) 
                volume = volume - acceleration;
            audioSrc.volume -= volume;
            yield return new WaitForSeconds(0.2f);
        }
    }

    /*
    IEnumerator DecreasSoundFromHalfToZero()
    {
        while (audioSrc.volume > 0f && !playerInside)
        {
            audioSrc.volume -= 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
    }*/
}
