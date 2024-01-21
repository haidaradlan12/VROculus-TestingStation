using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelVisualScriptHitam : MonoBehaviour
{
    public TestingScript scripttesting;
    public AnimationScript script;
    public GameObject ObjectTujuan, Pos1, Pos2, Pos3;
    public float translationSpeed;
    public bool papanbawah=false, plunger=false, tester=false;
    public bool Mulai = false;
    public bool klick = true;
    public bool plung = true;
    private void Update()
    {
        if (Mulai== true)
        {
            if (papanbawah == true && tester == false && plunger == false)
            {
                ObjectTujuan = Pos1;
                this.transform.position = Vector3.Lerp(this.transform.position, ObjectTujuan.transform.position, translationSpeed * Time.deltaTime);
                return;
                
            }
            if ((papanbawah == true || papanbawah == false) && tester == false && plunger == true)
            {
               ObjectTujuan = Pos2;
                this.transform.position = Vector3.Lerp(this.transform.position, ObjectTujuan.transform.position, translationSpeed * Time.deltaTime);
                return;
            }
            else if ((papanbawah == true || papanbawah == false) && tester == true && plunger == true)
            {
                ObjectTujuan = Pos3;
                this.transform.position = Vector3.Lerp(this.transform.position, ObjectTujuan.transform.position, translationSpeed * Time.deltaTime);
                return;
            }
        }
        else
        {
            papanbawah = false ; plunger = false; tester=false;
            if (plung == true)
            {
                scripttesting.plung = true;
                plung = false;
            }
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PapanBawah")
        {
            papanbawah = true;
            if (klick == true)
            {
                Mulai = true;
                klick = false;
            }
        }
        if (other.gameObject.tag == "Stop")
        {
            Mulai = false;
            this.transform.position = this.transform.position;
        }
        if (other.gameObject.tag == "BendaHitam")
        {
            Mulai = false;
            this.transform.position = this.transform.position;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "OnAnimBox")
        {
            script.BallIn = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "OnAnimBox")
        {
            script.BallIn = false;
        }
    }
  }
