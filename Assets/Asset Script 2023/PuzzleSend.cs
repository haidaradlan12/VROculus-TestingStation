using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSend : MonoBehaviour
{
    public PazzleReceive scriptinduk;
    public int pazzlekolom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Puzzle Naik")
        {
            scriptinduk.terima(pazzlekolom, "Puzzle (1)");
        }
        if (other.gameObject.name == "Puzzle Testing")
        {
            scriptinduk.terima(pazzlekolom, "Puzzle (2)");
        }
        if (other.gameObject.name == "Puzzle Plunger")
        {
            scriptinduk.terima(pazzlekolom, "Puzzle (3)");
        }
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Puzzle Naik")
        {
            scriptinduk.terima(pazzlekolom, "");
        }
        if (other.gameObject.name == "Puzzle Testing")
        {
            scriptinduk.terima(pazzlekolom, "");
        }
        if (other.gameObject.name == "Puzzle Plunger")
        {
            scriptinduk.terima(pazzlekolom, "");
        }
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
