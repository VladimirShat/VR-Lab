using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public Transform flask;
    public GameObject ps;

    // Update is called once per frame
    void Update()
    {
        float currentX = flask.eulerAngles.x;
        float currentZ = flask.eulerAngles.z;

        if ((currentX > 270 && currentX < 360) || (currentZ > 270 && currentZ < 360))
        {
            ps.SetActive(true);
        }
        else if (currentX > 0 && currentX < 270 && currentZ > 0 && currentZ < 270)
        {
            ps.SetActive(false);
        }
    }
}
