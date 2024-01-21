using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelVisualHilangkan: MonoBehaviour
{
    public GameObject Baloknya;
    public GameObject Paren;
    //public int banyaknya;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PapanBawah")
        {
            Destroy(Paren);
            Destroy(transform.gameObject);
            Baloknya.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PapanBawah")
        {
            Destroy(Paren);
            Destroy(transform.gameObject);
            Baloknya.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {

    }
}
