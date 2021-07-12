using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessScale : MonoBehaviour
{
    public GameObject whitePiece;

    public Vector3 scaleChange;
    public bool shrink = false;
    public bool maxminAchieved = true;

    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = new Vector3(1, 1, 1);
        scaleChange = new Vector3(0.0035f, 0.0035f, 0.0035f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!shrink)
        {
            if (transform.localScale.y < 0.85f)
                transform.localScale += scaleChange;
        }
        if (shrink)
        {
            if (transform.localScale.y > 0.007f)
                transform.localScale -= scaleChange;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == whitePiece)
        {
            //blackPawn1.GetComponent<Collider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;

        }
    }
}
