using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerHit : MonoBehaviour
{
    public TestingScript script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BendaHitam")
        {
            other.GetComponent<PanelVisualScriptHitam>().plunger = true;
            script.plung = false;
        }
        if (other.gameObject.tag == "Benda")
        {
            other.GetComponent<PanelVisualScriptHitam>().plunger = true;
        }
    }
}
