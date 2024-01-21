using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndikatorScript : MonoBehaviour
{
    public GameObject Merah, Hijau, Putih;

    private void Start()
    {
        Hijau.SetActive(false);
        Merah.SetActive(false);
        Putih.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            Hijau.SetActive(true);
            Merah.SetActive(false);
            Putih.SetActive(false);
        }
        else if (other.gameObject.tag == "BendaHitam")
        {
            Hijau.SetActive(false);
            Merah.SetActive(true);
            Putih.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            Hijau.SetActive(true);
            Merah.SetActive(false);
            Putih.SetActive(false);
        }
        else if (other.gameObject.tag == "BendaHitam")
        {
            Hijau.SetActive(false);
            Merah.SetActive(true);
            Putih.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            Hijau.SetActive(false);
            Merah.SetActive(false);
            Putih.SetActive(true);
        }
        else if (other.gameObject.tag == "BendaHitam")
        {
            Hijau.SetActive(false);
            Merah.SetActive(false);
            Putih.SetActive(true);
        }
    }
}
