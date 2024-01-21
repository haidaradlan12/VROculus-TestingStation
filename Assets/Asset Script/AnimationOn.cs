using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOn : MonoBehaviour
{
    public Animator anim;
    int a, b, c;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (a==1)
        {
            b++;
            if (b>10000)
            {
                anim.Play("Turun");
            }
        }
        else
        {
            b = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            anim.Play("Turun");
        }
        else if (other.gameObject.tag == "BendaHitam")
        {
            a = 1;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Benda")
        {
            c = 1;
        }
        else if (other.gameObject.tag == "BendaHitam")
        {
            c = 2; a = 0;
            //anim.Play("OtomatisHitam");
            //a = 0;
        }
    }
    public void ButtonNaik()
    {
        if (c == 1)
        {
            anim.Play("Naik");
        }
        else if (c == 2)
        {
            anim.Play("OtomatisHitam");
        }
    }


}
