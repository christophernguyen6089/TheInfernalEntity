using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class charUnit : MonoBehaviour
{

    public static bool gameOverFlag=false;
    public GameObject gameOverScreen;
    public GameObject parentHealingItem;
    public float playerMaxHealth = 10f;
    public float currentPlayerHealth = 10f;
    public float decreaseParameter=0f;
    public float levelLength;
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

        if(currentPlayerHealth>playerMaxHealth){
            currentPlayerHealth=playerMaxHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayerHealth-=Time.deltaTime*decreaseParameter;
        levelLength-=Time.deltaTime;
        healthSlider.value = currentPlayerHealth;

        if(currentPlayerHealth<=0f){
            characterMove.DebugLogPrint("Goodbye, world.");
            gameOverFlag=true;
            gameOverScreen.SetActive(true);
            parentHealingItem.SetActive(false);
            gameObject.SetActive(false);
        }
        if(levelLength<=0f){
            SceneManager.LoadScene("levelComplete"); 
        }
    }
}
