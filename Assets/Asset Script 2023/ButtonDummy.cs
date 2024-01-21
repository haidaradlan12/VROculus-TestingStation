using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDummy : MonoBehaviour
{
    public AnimationScript scriptinduk;
    public int number;
    private void OnMouseUpAsButton()
    {
        scriptinduk.MulaiSemua();
        Debug.Log("Kena");
    }
}
