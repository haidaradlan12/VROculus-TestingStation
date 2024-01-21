using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndikatorSensorScript : MonoBehaviour
{
    public bool Mulai = false;
    public GameObject ON, OFF;

    private void Start()
    {
        OFF.SetActive(true);
        ON.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (Mulai == true)
        {
            if (other.gameObject.tag == "Benda")
            {
                OFF.SetActive(false);
                ON.SetActive(true);
            }
            else if (other.gameObject.tag == "BendaHitam")
            {
                OFF.SetActive(false);
                ON.SetActive(true);
            }
        }
        
    }
    void OnTriggerStay(Collider other)
    {
        if (Mulai == true)
        {
            if (other.gameObject.tag == "Benda")
            {
                OFF.SetActive(false);
                ON.SetActive(true);
            }
            else if (other.gameObject.tag == "BendaHitam")
            {
                OFF.SetActive(false);
                ON.SetActive(true);
            }
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (Mulai == true)
        {
            if (other.gameObject.tag == "Benda")
            {
                OFF.SetActive(true);
                ON.SetActive(false);
            }
            else if (other.gameObject.tag == "BendaHitam")
            {
                OFF.SetActive(true);
                ON.SetActive(false);
            }
        }
        
    }
}
