using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defaultobject : MonoBehaviour
{
    Vector3 posnya, rotnya;
    // Start is called before the first frame update
    void Start()
    {
        posnya = this.transform.localPosition;
        rotnya = this.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = posnya;
        this.transform.localEulerAngles = rotnya;
    }
}
