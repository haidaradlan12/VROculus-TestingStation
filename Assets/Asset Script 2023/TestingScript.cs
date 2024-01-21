using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    public bool Mulai=false;
    public GameObject Awal;
    public float speed = 1;
    bool klick = true;
    bool sudah = true;
    public GameObject merah, hijau, biru;
    public bool plung = true;
    public bool balik = false;
    // Start is called before the first frame update
    void Start()
    {
        biru.SetActive(true);
        merah.SetActive(false);
        hijau.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mulai == true)
        {
            this.GetComponent<Animator>().Play("TestingAnimation");
        }

        if (this.transform.localPosition.y == Awal.transform.localPosition.y)
        {
            this.GetComponent<Animator>().speed = 1;
            sudah = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            this.GetComponent<Animator>().speed = 0;
            tambahstep();
            biru.SetActive(false);
            merah.SetActive(false);
            hijau.SetActive(true);
            Mulai = false;
        }
        if (other.gameObject.tag == "BendaHitam")
        {
            this.GetComponent<Animator>().speed = 0;
            tambahstep();
            biru.SetActive(false);
            merah.SetActive(true);
            hijau.SetActive(false);
            Mulai = false;
        }
        if (other.gameObject.tag == "Pendorong")
        {
            this.GetComponent<Animator>().speed = 0;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "BendaHitam")
        {
            GameObject gam = other.gameObject;
            gam.GetComponent<PanelVisualScriptHitam>().tester = true;
        }
        if (other.gameObject.tag == "Benda")
        {
            GameObject gam = other.gameObject;
            gam.GetComponent<PanelVisualScriptHitam>().tester = true;
        }
        if (other.gameObject.tag == "Pendorong")
        {
            this.GetComponent<Animator>().speed = 0;
            balik = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            if (balik == false)
            {
                this.GetComponent<Animator>().speed = 1;
            }
            if (plung == true)
            {
                GameObject gam = other.gameObject;
                gam.GetComponent<PanelVisualScriptHitam>().tester = true;
            }            
            biru.SetActive(true);
            merah.SetActive(false);
            hijau.SetActive(false);
        }
        if (other.gameObject.tag == "BendaHitam")
        {
            if (balik == false)
            {
                this.GetComponent<Animator>().speed = 1;
            }
            if (plung == true)
            {
                GameObject gam = other.gameObject;
                gam.GetComponent<PanelVisualScriptHitam>().tester = true;
            }
            biru.SetActive(true);
            merah.SetActive(false);
            hijau.SetActive(false);
        }
        if (other.gameObject.tag == "Pendorong")
        {
            //this.GetComponent<Animator>().speed = 1;
        }
    }
    public void resettempat()
    {
        Mulai = false;
        this.GetComponent<Animator>().Play("NaikLagi");
    }
    public void naiklagi()
    {
        Mulai = false;
        this.GetComponent<Animator>().Play("NaikLagi");
    }
    public void tambahstep()
    {
        if (sudah == true)
        {
            FindObjectOfType<AnimationScript>().tambah();
            klick = true;
            sudah = false;
        }      
    }
    public void mulai()
    {
        if (klick == true)
        {
            Mulai = true;
            klick = false;
        }
    }
}
