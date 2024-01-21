using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleAutoONSend : MonoBehaviour
{
    public PazzleReceive scriptinduk;
    public TombolTrainer tombol;
    public bool sensor=false;
    public int pazzlekolom=0;
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
        if (sensor == false)
        {
            if (other.gameObject.name == "Puzzle On")
            {
                scriptinduk.OnAuto = "ON";
                tombol.dataterima = "On";
            }
            if (other.gameObject.name == "Puzzle Stop")
            {
                scriptinduk.OnAuto = "ON";
                tombol.dataterima = "Stop";
            }
            if (other.gameObject.name == "Puzzle Reset")
            {
                scriptinduk.OnAuto = "ON";
                tombol.dataterima = "Reset";
            }
            if (other.gameObject.name == "Puzzle Auto/Man")
            {
                scriptinduk.OnAuto = "ON";
                tombol.dataterima = "Auto/Man";
            }
            if (other.gameObject.name == "Puzzle Q1")
            {
                scriptinduk.OnAuto = "ON";
                tombol.dataterima = "Q1";
            }
            if (other.gameObject.name == "Puzzle Q2")
            {
                scriptinduk.OnAuto = "ON";
                tombol.dataterima = "Q2";
            }
            if (other.gameObject.name == "Puzzle Auto")
            {
                scriptinduk.OnAuto = "Auto";
            }
        }
        else
        {
            if (other.gameObject.name == "Puzzle Sensor")
            {
                scriptinduk.terimaSensor(pazzlekolom, "Sensor (1)");
            }
            if (other.gameObject.name == "Puzzle Sensor Atas")
            {
                scriptinduk.terimaSensor(pazzlekolom, "Sensor (2)");
            }
            if (other.gameObject.name == "Puzzle Sensor Testing")
            {
                scriptinduk.terimaSensor(pazzlekolom, "Sensor (3)");
            }
        }
        
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
    private void OnTriggerExit(Collider other)
    {
        if (sensor == false)
        {
            if (other.gameObject.name == "Puzzle On")
            {
                scriptinduk.OnAuto = "";
            }
            if (other.gameObject.name == "Puzzle Auto")
            {
                scriptinduk.OnAuto = "";
            }
        }
        else
        {
            if (other.gameObject.name == "Puzzle Sensor")
            {
                scriptinduk.terimaSensor(pazzlekolom, "");
            }
            if (other.gameObject.name == "Puzzle Sensor Atas")
            {
                scriptinduk.terimaSensor(pazzlekolom, "");
            }
            if (other.gameObject.name == "Puzzle Sensor Testing")
            {
                scriptinduk.terimaSensor(pazzlekolom, "");
            }
        }
        
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
