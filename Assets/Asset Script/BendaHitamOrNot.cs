using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BendaHitamOrNot : MonoBehaviour
{
    public AnimationScript script;
    public string tagBenar, tagSalah;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == tagBenar)
        {
            script.Bolabenar = true;
        }
        if (other.gameObject.tag == tagSalah)
        {
            script.Bolabenar = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == tagBenar)
        {
            script.Bolabenar = true;
        }
        if (other.gameObject.tag == tagSalah)
        {
            script.Bolabenar = false;
        }
    }
}
