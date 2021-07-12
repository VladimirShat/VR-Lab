using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomScript : MonoBehaviour
{
    public bool highlighted = false;
    public Material baseMaterial;
    public Material highMaterial;
    MeshRenderer meshRenderer;
    public Canvas label;
    public Animator transition;
    public float transitionTime;
    bool labelWidened;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        label.enabled = false;
        labelWidened = false;
        // Get the current material applied on the GameObject

    }

    // Update is called once per frame
    void Update()
    {
        if (highlighted)
        {
            labelWidened = true;
            meshRenderer.material = highMaterial;
            label.enabled = true;
            WideLabel();
            
        }
        if (!highlighted)
        {
            meshRenderer.material = baseMaterial;
            if (labelWidened) StartCoroutine(UnwideLabel());
        }
    }

    void WideLabel()
    {
        transition.ResetTrigger("End");
        transition.SetTrigger("Start");
    }
    IEnumerator UnwideLabel()
    {
        transition.ResetTrigger("Start");
        transition.SetTrigger("End");

        yield return new WaitForSeconds(transitionTime);
        label.enabled = false;
        labelWidened = false;
    }
}
