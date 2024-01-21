using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationScript : MonoBehaviour
{
    public string Hasil;
    public IndikatorSensorScript[] sensorobject;
    public TestingScript testingObject;
    public NaikScript trainerObject;
    public string Satu, Dua, Tiga;
    public string onauto, sensor, sensorAtas, sensorTesting;
    public bool Sensor, SensorAtas, SensorTesting;
    public int step;
    bool Stop = false;
    public bool Mulai = false;
    public bool klik = true;
    public bool BallIn = false;
    public bool Starting = false;
    public bool Bolabenar = false;
    public GameObject tombolReload;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Stop == true)
        {
            if (step == 0)
            {
                Mulai = false;
                klik = false;
                StopCoroutine(Auto());
            }
        }
        if (sensor == "Sensor (1)")
        {
            Sensor = true;
        }
        else
        {
            Sensor = false;
        }
        if (sensorAtas == "Sensor (2)")
        {
            SensorAtas = true;
        }
        else
        {
            SensorAtas = false;
        }
        if (sensorTesting == "Sensor (3)")
        {
            SensorTesting = true;
        }
        else
        {
            SensorTesting = false;
        }
        for (int i = 0; i < sensorobject.Length; i++)
        {
            sensorobject[i].Mulai = Sensor;
        }
        //pazle 1 naik
        //pazle 2 testing
        //pazle 3 plunger
        if (Mulai == true && BallIn == true && Sensor == true && SensorAtas == true && SensorTesting == true)
        {
            if (klik == true)
            {
                StopCoroutine(Auto());
                step = 1;
                Starting = true;
                klik = false;

            }

            if (onauto == "ON")
            {
                Mulai = false;
            }
            else if (onauto == "Auto")
            {
                Mulai = true;
            }
        }
        if (step == 0)
        {
            Starting = false;
        }
        if (Satu == "Puzzle (1)" && Dua == "Puzzle (2)" && Tiga == "Puzzle (3)" && sensor == "Sensor (1)" && sensorAtas == "Sensor (2)" && sensorTesting == "Sensor (3)")
        {
            Hasil = "Berhasil";
            if (Starting == true)
            {
                if (step == 1)
                {
                    trainerObject.Naik();
                }
                else if (step == 2)
                {
                    testingObject.mulai();
                }
                else if (step == 3)
                {
                    if (Bolabenar == true)
                    {
                        trainerObject.Plunger();
                    }
                    else
                    {
                        step = 4;
                    }
                }
                else if (step == 4)
                {
                    trainerObject.Turun();
                }
                else
                {
                    step = 0;
                    if (onauto == "Auto")
                    {
                        StartCoroutine(Auto());
                    }
                }
            }
        }
        else
        {
            Hasil = "Error";
            tombolReload.SetActive(true);
        }

    }
    public void DataMasuk(string satu, string dua, string tiga)
    {
        Satu = satu;
        Dua = dua;
        Tiga = tiga;
    }
    public void DataSensorMasuk(string satu, string dua, string tiga)
    {
        sensor = satu;
        sensorAtas = dua;
        sensorTesting = tiga;
    }
    public void tambah()
    {
        step += 1;
    }
    public void MulaiSemua()
    {
        klik = true;
        Mulai = true;
    }
    public void StopAll()
    {
        Stop = true;
    }
    IEnumerator Auto()
    {
        yield return new WaitForSeconds(4f);
        klik = true;
    }
    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
