using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculusButton : MonoBehaviour
{
    private enum ButtonStates { On, Off};

    public Material offMaterial;
    public Material onMaterial;

    public GameObject moleculus;

    ButtonStates state = ButtonStates.Off;

    private void Start()
    {
        GetComponent<MeshRenderer>().sharedMaterial = offMaterial;
        moleculus.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(state == ButtonStates.Off)
        {
            GetComponent<MeshRenderer>().sharedMaterial = offMaterial;
            moleculus.GetComponent<MoleculsController>().enlarge = false;
            state = ButtonStates.On;
        }
        else if(state == ButtonStates.On)
        {
            GetComponent<MeshRenderer>().sharedMaterial = onMaterial;
            moleculus.GetComponent<MoleculsController>().enlarge = true;
            state = ButtonStates.Off;
        }
    }
}
