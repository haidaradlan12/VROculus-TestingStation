using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombolTrainer : MonoBehaviour
{
    public AnimationScript scriptinduk;
    public string dataterima;
    int pilihan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dataterima == "On")
        {
            pilihan = 0;
        }
        else if(dataterima == "Stop")
        {
            pilihan = 1;
        }
        else if (dataterima == "Reset")
        {
            pilihan = 2;
        }
        else if (dataterima == "Auto/Man")
        {
            pilihan = 3;
        }
        else if (dataterima == "Q1")
        {
            pilihan = 4;
        }
        else if (dataterima == "Q2")
        {
            pilihan = 5;
        }
    }

    public void MulaiAnimasi(int nilai)
    {
        if (nilai == pilihan)
        {
            scriptinduk.MulaiSemua();
        }
    }
}
