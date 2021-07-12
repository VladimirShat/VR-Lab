using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Detector : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject whiteMolecul;
    public GameObject redMolecul;
    public GameObject blueMolecul;

    public Animator moleculTransition;
    public Animator textTransition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "White Flask")
        {
            text.gameObject.SetActive(true);
            text.text = "C8H7N3O2";
            whiteMolecul.SetActive(true);
            moleculTransition = whiteMolecul.GetComponent<Animator>();
            WideLabel();
        }
        else if (other.gameObject.name == "Red Flask")
        {
            text.gameObject.SetActive(true);
            text.text = "K3[Fe(CN)6] + H2O2";
            redMolecul.SetActive(true);
            moleculTransition = redMolecul.GetComponent<Animator>();
            WideLabel();
        }
        else if (other.gameObject.name == "Blue Flask")
        {
            text.gameObject.SetActive(true);
            text.text = "C8H7N3O2";
            blueMolecul.SetActive(true);
            moleculTransition = blueMolecul.GetComponent<Animator>();
            WideLabel();
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.name == "White Flask")
        {
            StartCoroutine(UnwideLabel(whiteMolecul));
        }
        else if (other.gameObject.name == "Red Flask")
        {
            StartCoroutine(UnwideLabel(redMolecul));
        }
        else if (other.gameObject.name == "Blue Flask")
        {
            StartCoroutine(UnwideLabel(blueMolecul));
        }
    }

    void WideLabel()
    {
        moleculTransition.ResetTrigger("Shrink");
        moleculTransition.SetTrigger("Enlarge");
        textTransition.ResetTrigger("Shrink");
        textTransition.SetTrigger("Enlarge");
    }
    IEnumerator UnwideLabel(GameObject molecul)
    {
        moleculTransition.ResetTrigger("Enlarge");
        moleculTransition.SetTrigger("Shrink"); 
        textTransition.ResetTrigger("Enlarge");
        textTransition.SetTrigger("Shrink");
        

        yield return new WaitForSeconds(1f);

        molecul.SetActive(false);
        text.text = "";
        text.gameObject.SetActive(false);
    }
}
