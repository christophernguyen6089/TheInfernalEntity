using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class charUnit : MonoBehaviour
{

    public float playerMaxHealth = 10f;
    public float currentPlayerHealth = 10f;
    //based on napkin math, 1f is roughly equal to 1 second, so this will give about 10 seconds of leeway... i think

    public Slider healthSlider;
    

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = 10f;
        healthSlider.minValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayerHealth-=Time.deltaTime;
        healthSlider.value = currentPlayerHealth;

        if(currentPlayerHealth<=0f){
           characterMove.DebugLogPrint("Goodbye, world.");
            gameObject.SetActive(false);
        }
    }
}
