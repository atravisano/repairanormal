using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject lightBulb;
    private Light light;
    public float lifeIntensity = 1;

    // Start is called before the first frame update
    void Start()
    {
        light = lightBulb.GetComponent<Light>();
        light.intensity = lifeIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeIntensity >= 0) {
            lifeIntensity -= .001f;
            light.intensity = lifeIntensity;
        }
    }
}
