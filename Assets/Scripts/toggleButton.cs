using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleButton : MonoBehaviour
{

    public GameObject GameManager;
    private GameManager manager;
    

    private int PERCENT_CHANCE_OF_BREAK = 10;
    private float BREAK_START_DELAY = 15.0f;
    private float BREAK_ROLL_INTERVAL = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.GetComponent<GameManager>();
        InvokeRepeating("breakButton", BREAK_START_DELAY, BREAK_ROLL_INTERVAL); // delay for 15s, then repeat every 10s

        manager.breakPanelButtons(1);
    }

    // Update is called once per frame
    void Update()
    {

        // if button is illuminated, shut off illumination else do opposite (thisButton's light intensity = 1ish or 0 ??)


        
    }

    public void breakButton0(){  }

    void randomRoll(){

        float roll = Random.Range(0.0f, 100.0f);

        if (roll <= PERCENT_CHANCE_OF_BREAK) {

            manager.breakPanelButtons(1);

        }
    }

}
