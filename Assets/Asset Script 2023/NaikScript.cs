using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaikScript : MonoBehaviour
{
    public TestingScript script;
    public bool Mulai = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void tambahstep()
    {
        FindObjectOfType<AnimationScript>().tambah();
    }
    public void Naik()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Naik"); 
        this.gameObject.GetComponent<Animator>().ResetTrigger("Turun");
        this.gameObject.GetComponent<Animator>().ResetTrigger("Plunger");
    }
    public void Plunger()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Plunger");
        this.gameObject.GetComponent<Animator>().ResetTrigger("Turun");
        this.gameObject.GetComponent<Animator>().ResetTrigger("Naik");
    }
    public void Turun()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Turun");
        this.gameObject.GetComponent<Animator>().ResetTrigger("Naik");
        this.gameObject.GetComponent<Animator>().ResetTrigger("Plunger");
    }
    public void PlungerDown()
    {
        this.gameObject.GetComponent<Animator>().ResetTrigger("Plunger");
    }

    public void plungaktif()
    {
        script.balik = false;
        script.GetComponent<Animator>().speed = 1;
    }
}
