using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    // THE Light
    public GameObject lightBulb;
    private Light light;

    // Player
    public float lifeIntensity = 1;

    // Button Panel
    private bool[] buttonState = new bool[6];
    public GameObject buttonPanel;



    void Awake()
    {
        light = lightBulb.GetComponent<Light>();
    }


    // Start is called before the first frame update
    void Start()
    {
        light.intensity = lifeIntensity;
    }


    // Update is called once per frame
    void Update()
    {
        if(lifeIntensity >= 0 && !getPanelButtonState()) {
            lifeIntensity -= .001f;
            light.intensity = lifeIntensity;
        }
    }


    public void panelButtonPressed0(){ buttonState[0] = !buttonState[0]; buttonState[3] = !buttonState[3]; }
    public void panelButtonPressed1(){ buttonState[1] = !buttonState[1]; buttonState[4] = !buttonState[4]; }
    public void panelButtonPressed2(){ buttonState[2] = !buttonState[2]; buttonState[5] = !buttonState[5]; }
    public void panelButtonPressed3(){ buttonState[3] = !buttonState[3]; buttonState[0] = !buttonState[0]; }
    public void panelButtonPressed4(){ buttonState[4] = !buttonState[4]; buttonState[1] = !buttonState[1]; }
    public void panelButtonPressed5(){ buttonState[5] = !buttonState[5]; buttonState[5] = !buttonState[5]; }

    /*public void getButtonState0(){ return buttonState[0]; }
    public void getButtonState1(){ return buttonState[1]; }
    public void getButtonState2(){ return buttonState[2]; }
    public void getButtonState3(){ return buttonState[3]; }
    public void getButtonState4(){ return buttonState[4]; }
    public void getButtonState5(){ return buttonState[5]; }*/

    private bool getPanelButtonState(){
        if(
            buttonState[0] == true &&
            buttonState[1] == true &&
            buttonState[2] == true &&
            buttonState[3] == false &&
            buttonState[4] == false &&
            buttonState[5] == false
        ){
            return true;
        }
        else
        {
            return false;
        }
    }

}
