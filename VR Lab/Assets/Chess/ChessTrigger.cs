using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessTrigger : MonoBehaviour
{
    public GameObject blackPawn1;
    public GameObject whiteKnight;
    public GameObject blackPawn2;
    public GameObject whitePawn;
    public GameObject blackFerz;
    public GameObject whiteKnight2;

    public bool movePawn = false;
    public bool moveFerz = false;
    Vector3 d;
    Vector3 bpStartPos;
    Vector3 dFerz;
    Vector3 ferzStartPos;

    // Start is called before the first frame update
    void Start()
    {
        d = new Vector3(whitePawn.transform.position.x - blackPawn2.transform.position.x, whitePawn.transform.position.y - blackPawn2.transform.position.y, whitePawn.transform.position.z - blackPawn2.transform.position.z);
        bpStartPos = new Vector3(blackPawn2.transform.position.x, blackPawn2.transform.position.y, blackPawn2.transform.position.z);
        dFerz = new Vector3(whiteKnight2.transform.position.x - blackFerz.transform.position.x, whiteKnight2.transform.position.y - blackFerz.transform.position.y, whiteKnight2.transform.position.z - blackFerz.transform.position.z);
        ferzStartPos = new Vector3(blackFerz.transform.position.x, blackFerz.transform.position.y, blackFerz.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (movePawn)
        {
            if (!(blackPawn2.transform.position.x - d.x < bpStartPos.x))
                blackPawn2.transform.Translate(-d * 0.5f * Time.deltaTime);
            else
            {
                movePawn = false;
                whitePawn.GetComponent<ChessScale>().shrink = true;
            }
            
        }
        if (moveFerz)
        {
            if (!(blackFerz.transform.position.x - dFerz.x >= ferzStartPos.x))
                blackFerz.transform.Translate(-dFerz * 0.5f * Time.deltaTime);
            else
            {
                moveFerz = false;
                whiteKnight2.GetComponent<ChessScale>().shrink = true;
            }

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == whiteKnight)
        {
            //blackPawn1.GetComponent<Collider>().enabled = false;
            blackPawn1.GetComponent<ChessScale>().shrink = true;
            StartCoroutine(BlackPawnMove());
        }
    }

    IEnumerator BlackPawnMove()
    {
        yield return new WaitForSeconds(2f);

        movePawn = true;
        
        
    }
}
