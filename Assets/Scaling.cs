using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    public GameObject lightbulb;
    private Light light;
    public float initialYScale;
    public float initialRange;

    // Start is called before the first frame update
    void Start()
    {
        lightbulb = GameObject.Find("The Light Bulb");
        light = lightbulb.GetComponent<Light>();
        initialYScale = this.transform.localScale.y;
        initialRange = light.range;
    }

    // Update is called once per frame
    void Update()
    {

        if(this.transform.localScale.y >= 0.0f) {
            this.transform.localScale = new Vector3(this.transform.localScale.x, initialYScale * (light.range/initialRange), this.transform.localScale.z);
        }
    }
}
