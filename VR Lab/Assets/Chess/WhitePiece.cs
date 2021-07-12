using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePiece : MonoBehaviour
{
    public string pieceName;
    public bool placed;
    public int[,,] moves;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        placed = PiecePlaced();
    }

    bool PiecePlaced()
    {
        Vector3 rayO = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        RaycastHit hit;
        if (Physics.Raycast(rayO, transform.TransformDirection(Vector3.down), out hit, 1f) && hit.collider.tag == "Cell")
        {
            Debug.DrawRay(rayO, transform.TransformDirection(Vector3.down) * hit.distance);
            Debug.Log("Did Hit");
            return true;
        }
        else return false;
    }
}
