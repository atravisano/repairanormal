using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Fuse
    public bool FuseInstalled;
    public AudioSource audioSource;
    public AudioClip PoweredSound;
    public AudioClip DrainingSound;

    public GameObject GameOverSlate;
    
    // THE Light
    public GameObject lightBulb;
    private Light light;

    // Player
    public float lifeIntensity = 0;

    // Button Panel
    private bool[] buttonState = new bool[6];
    public GameObject buttonPanel;

    private bool wasPreviouslyPowered = false;
    private float originalLifeIntensity;

    void Awake()
    {
        light = lightBulb.GetComponent<Light>();

        buttonState[0] = false;
        buttonState[1] = true;
        buttonState[2] = true;
        buttonState[3] = false;
        buttonState[4] = true;
        buttonState[5] = false;
    }


    void Start()
    {
        originalLifeIntensity = light.range;
        lifeIntensity = light.range;
        audioSource.loop = true;
        audioSource.clip = DrainingSound;
        audioSource.Play();
    }


    void Update()
    {
        if(lifeIntensity >= 0) {
            if (!FuseInstalled || !isPanelInSuccessState())
            {
                // Draining power
                lifeIntensity -= .001f;
                light.range = lifeIntensity;
                
                if (wasPreviouslyPowered) {
                    audioSource.Stop();
                    audioSource.loop = true;
                    audioSource.clip = DrainingSound;
                    audioSource.Play();
                }
                wasPreviouslyPowered = false;
            }
            else
            {
                // Everything is powered
                if (!wasPreviouslyPowered) {
                    audioSource.Stop();
                    audioSource.loop = false;
                    audioSource.clip = PoweredSound;
                    audioSource.Play();
                }
                wasPreviouslyPowered = true;
            }
        }
        else {
            StartCoroutine(GameOverSequence());
        }
    }

    IEnumerator GameOverSequence()
    {
        GameOverSlate.SetActive(true);
        yield return new WaitForSeconds(5); 
        ResetGame();
    }

    public void panelButtonPressed0(){ Debug.Log("pressed"); buttonState[0] = !buttonState[0]; buttonState[1] = !buttonState[1]; }
    public void panelButtonPressed1(){ buttonState[1] = !buttonState[1]; buttonState[0] = !buttonState[0]; }
    public void panelButtonPressed2(){ buttonState[2] = !buttonState[2]; buttonState[3] = !buttonState[3]; }
    public void panelButtonPressed3(){ buttonState[3] = !buttonState[3]; buttonState[2] = !buttonState[2]; }
    public void panelButtonPressed4(){ buttonState[4] = !buttonState[4]; buttonState[5] = !buttonState[5]; }
    public void panelButtonPressed5(){ buttonState[5] = !buttonState[5]; buttonState[4] = !buttonState[4]; }

    public void ResetGame()
    {
        GameOverSlate.SetActive(false);
        Debug.Log("Restarting");
        lifeIntensity = originalLifeIntensity;
    }

    private bool isPanelInSuccessState(){
        return true;
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

    public void breakPanelButtons(int index){

        if(index == 0 && buttonState[0] == true){ panelButtonPressed0(); }
        if(index == 1 && buttonState[2] == true){ panelButtonPressed2(); }
        if(index == 2 && buttonState[4] == true){ panelButtonPressed4(); }

    }

    public bool getButtonState(int index){

        return buttonState[index];

    }

}
