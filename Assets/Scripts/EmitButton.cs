using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitButton : MonoBehaviour
{
    public GameObject GameManager;
    private GameManager manager;

    public int index = 0;

    // Start is called before the first frame update
    void Start()
    {
     manager = GameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        bool isOn = manager.getButtonState(index);

        if(isOn){

            this.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");

        }else{

            this.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

        }

    }

}
