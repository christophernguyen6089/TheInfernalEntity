using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class charUnit : MonoBehaviour
{
    public static int score=0;
    public static bool gameOverFlag=false;

    public GameObject parentHealingItem;
    public float playerMaxHealth = 10f;
    public float currentPlayerHealth = 10f;
    public float decreaseParameter=0f;
    public float levelLength;

    public Slider healthSlider;
    public Slider timeSlider;

    
    

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = 10f;
        healthSlider.minValue = 0f;
        timeSlider.maxValue=levelLength;
        timeSlider.minValue=0f;
    }

    public void heal(float amount){
        currentPlayerHealth+=amount;

        if(currentPlayerHealth>playerMaxHealth){
            currentPlayerHealth=playerMaxHealth;
        }
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayerHealth-=Time.deltaTime*decreaseParameter;
        levelLength-=Time.deltaTime;
        healthSlider.value = currentPlayerHealth;
        timeSlider.value = levelLength;

        if(currentPlayerHealth<=0f){
            
            gameOverFlag=true;
            
            parentHealingItem.SetActive(false);

            SceneManager.LoadScene("gameOver");
            gameObject.SetActive(false);
        }
        if(levelLength<=0f){
            SceneManager.LoadScene("levelComplete"); 
        }
    }
}
