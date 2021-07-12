using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageTrigger : MonoBehaviour
{
    public GameObject cage;

    void OnTriggerEnter(Collider other)
    {
        cage.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        cage.SetActive(false);
    }
}
