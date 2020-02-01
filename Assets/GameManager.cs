using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject lightBulb;
    public GameObject buttonPanel;
    private Light light;
    public float lifeIntensity = 1;
    bool buttonsInSuccessState = true;

    void Awake()
    {
        Debug.Log("Woke...");
        light = lightBulb.GetComponent<Light>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started...");
        light.intensity = lifeIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeIntensity >= 0 && !buttonsInSuccessState) {
            lifeIntensity -= .001f;
            light.intensity = lifeIntensity;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {

            Debug.Log("Spaced...");
            panelButtonPressed();

        }
    }

    public void panelButtonPressed(){

        Debug.Log("panelButtonPressed...YAY");

        Component[] buttons = buttonPanel.GetComponentsInChildren(typeof(Component));

        int index = 0;

        foreach (Component button in buttons)
        {   

            //DumpToConsole(button);

        }
        /*
            buttons.Add(child.gameObject);

            if( ButtonIsOn ){ 
                // add to on buttons
            }
            
            if(index % 2 > 0){

                // turn off previous button

            } else {

                // turn off next button

            }

            index++;
        }

        /*if ( onButtons array includes only the 3 correct buttons ){



        }
        else
        {



        }*/
    
    }

}
