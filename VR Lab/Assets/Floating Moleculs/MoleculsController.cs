using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculsController : MonoBehaviour
{
    public Vector3 scaleChange;
    public bool enlarge = false;
    public bool maxminAchieved = true;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
        scaleChange = new Vector3(0.007f, 0.007f, 0.007f);
    }

    // Update is called once per frame
    void Update()
    {
        if (enlarge)
        {
            if (transform.localScale.y < 1f)
                transform.localScale += scaleChange;
        }
        if (!enlarge)
        {
            if (transform.localScale.y > 0.007f)
                transform.localScale -= scaleChange;
        }
    }
}
