using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class charUnit : MonoBehaviour
{
    public GameObject gameOverScreen;
    public float playerMaxHealth = 10f;
    public float currentPlayerHealth = 10f;
    public float decreaseParameter=0f;
    //based on napkin math, 1f is roughly equal to 1 second, so this will give about 10 seconds of leeway... i think

    public Slider healthSlider;

    
    

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
        healthSlider.maxValue = 10f;
        healthSlider.minValue = 0f;
    }

    public void heal(float amount){
        currentPlayerHealth+=amount;
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayerHealth-=Time.deltaTime*decreaseParameter;
        healthSlider.value = currentPlayerHealth;

        if(currentPlayerHealth<=0f){
           characterMove.DebugLogPrint("Goodbye, world.");
            gameOverScreen.SetActive(true);

            gameObject.SetActive(false);
        }
    }
}
