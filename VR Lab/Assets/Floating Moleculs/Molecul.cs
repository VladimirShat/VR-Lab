using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecul : MonoBehaviour
{
    Vector3 dir;
    public GameObject controller;
    public float speed = 0.0002f;

    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition -= dir * speed;
        //transform.Translate(dir * 0.0005f);
    }
}
