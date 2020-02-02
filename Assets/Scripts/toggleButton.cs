using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleButton : MonoBehaviour
{

    public GameObject GameManager;
    private GameManager manager;

    private GameObject button;

    public int index = 0;
    

    private int PERCENT_CHANCE_OF_BREAK = 42;
    private float BREAK_START_DELAY = 5.0f;
    private float BREAK_ROLL_INTERVAL = 7.0f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this);
        manager = GameManager.GetComponent<GameManager>();

        button = this.GetComponent<GameObject>();

        InvokeRepeating("rollForBreakChance", BREAK_START_DELAY, BREAK_ROLL_INTERVAL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void rollForBreakChance(){

        float roll = Random.Range(0.0f, 100.0f);

        if (roll <= PERCENT_CHANCE_OF_BREAK) {

            manager.breakPanelButtons(index);

        }
    }

}
