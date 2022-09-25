using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    public static int playerLevelNum;
    // Start is called before the first frame update
    void Start()
    {
        playerLevelNum++;
    }

    public void nextLevel(){
        
        string newLevel = "Level"+playerLevelNum;
        if(playerLevelNum!=3){
            SceneManager.LoadScene(newLevel);
        }
        else{
            SceneManager.LoadScene("MainMenu");
        }
        
    }

}
