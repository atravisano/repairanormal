using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    public GameObject indicator;
    private Transform indicatorCylinder;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localScale.y >= 0.0f)
            this.transform.localScale -= new Vector3(0,.001f,0);
    }
}
