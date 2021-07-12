using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{
    public TextMeshPro TextMesh;
    private int count = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cube")
        {
            count = count + 1;
            TextMesh.text = count.ToString();
        }
    }
}
