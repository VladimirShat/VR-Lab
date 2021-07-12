using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixingTrigger : MonoBehaviour
{
    public ReactionController reactionController;
    public GameObject[] particles;
    public ParticleScript pscript;

    private float enterTime;
    private float deltaTime;

    private void OnTriggerEnter(Collider other)
    {
        enterTime = Time.time;
    }

    private void OnTriggerStay(Collider other)
    {
        deltaTime = Time.time - enterTime;

        if (deltaTime > 5.0f)
        {
            reactionController.ChangeResultMaterial();

            pscript.enabled = false;
            foreach(var particle in particles)
            {
                particle.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        deltaTime = 0;
    }
}
