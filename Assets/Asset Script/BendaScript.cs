using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BendaScript : MonoBehaviour
{
    public float translationSpeed = 1.0f;
    public float translationSpeed2 = 2.0f;
    public float translationSpeed3 = 1.0f;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PapanBawah")
        {
            transform.Translate(0, 0, -translationSpeed * Time.deltaTime);
        }
        else if (other.gameObject.tag == "Pendorong")
        {
            transform.Translate(0, 0, +translationSpeed2 * Time.deltaTime);
        }
        else if (other.gameObject.tag == "PapanAtas")
        {
            transform.Translate(0, 0, +translationSpeed3 * Time.deltaTime);
        }
        else if (other.gameObject.tag == "PenahanAtas")
        {
            transform.Translate(0, 0, 0);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PapanBawah")
        {
            transform.Translate(0, 0, -translationSpeed * Time.deltaTime);
        }
        else if (other.gameObject.tag == "Pendorong")
        {
            transform.Translate(0, 0, +translationSpeed2 * Time.deltaTime);
        }
        else if (other.gameObject.tag == "PapanAtas")
        {
            transform.Translate(0, 0, +translationSpeed3 * Time.deltaTime);
        }
        else if (other.gameObject.tag == "PenahanAtas")
        {
            transform.Translate(0, 0, 0);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PenahanAtas")
        {
            transform.Translate(0, 0, 0);
        }
    }
}
