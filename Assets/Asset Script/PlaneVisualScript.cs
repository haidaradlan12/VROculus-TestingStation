using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneVisualScript : MonoBehaviour
{
    public float translationSpeed;
    public float translationSpeed2;
    public float translationSpeed3;
    int a, b;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PapanBawah")
        {
            transform.Translate(0, 0, +translationSpeed * Time.deltaTime);
        }
        else if (other.gameObject.tag == "Pendorong")
        {
            transform.Translate(0, 0, -translationSpeed2 * Time.deltaTime);
        }
        else if (other.gameObject.tag == "PapanAtas")
        {
            transform.Translate(0, 0, -translationSpeed3 * Time.deltaTime);
            //print("enter papanatas");
        }
        else if (other.gameObject.tag == "Benda")
        {
           // print("enter Benda");
            b = 1;
        }
        else if (other.gameObject.tag == "PenahanAtas")
        {
           // print("enter Penahan");
            b = 1;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PapanBawah")
        {
            transform.Translate(0, 0, +translationSpeed * Time.deltaTime);
        }
        else if (other.gameObject.tag == "Pendorong")
        {
            transform.Translate(0, 0, -translationSpeed2 * Time.deltaTime);
        }
        else if (other.gameObject.tag == "PapanAtas")
        {
            a = 1;
            //print("stay papanatas");
            jalankan();
        }
        else if (other.gameObject.tag == "Benda")
        {
           // print("Stay Benda");
            b = 1;
        }
        else if (other.gameObject.tag == "PenahanAtas")
        {
           // print("stay Penahan");
            b = 1;
            //transform.Translate(0, 0, 0);
        }
    }
    void OnTriggerExit(Collider other)
    {
        
    }

    void jalankan()
    {
        if (a==1 && b==0)
        {
            transform.Translate(0, 0, -translationSpeed3 * Time.deltaTime);
        }
        else if (a==1 && b==1)
        {
            transform.Translate(0, 0, 0);
        }
    }
}
