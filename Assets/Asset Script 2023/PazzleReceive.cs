using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleReceive : MonoBehaviour
{
    public AnimationScript animationScript;
    public string Pertama, Kedua, Ketiga;
    public string SOne, STwo, SThree;
    public string OnAuto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animationScript.DataMasuk(Pertama, Kedua, Ketiga);
        animationScript.DataSensorMasuk(SOne, STwo, SThree);
        animationScript.sensor = SOne;
        animationScript.sensorAtas = STwo;
        animationScript.sensorTesting = SThree;
        animationScript.onauto = OnAuto;
    }
    public void terima(int i, string nilai)
    {
        if (i == 1)
        {
            Pertama = nilai;
        }
        else if (i == 2)
        {
            Kedua = nilai;
        }
        else if (i == 3)
        {
            Ketiga = nilai;
        }
    }
    public void terimaSensor(int i, string nilai)
    {
        if (i == 1)
        {
            SOne = nilai;
        }
        else if (i == 2)
        {
            STwo = nilai;
        }
        else if (i == 3)
        {
            SThree = nilai;
        }
    }
}
