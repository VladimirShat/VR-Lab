using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedMolecul : MonoBehaviour
{
    public float speed = 25f;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(dir * speed * Time.deltaTime);
    }
}
