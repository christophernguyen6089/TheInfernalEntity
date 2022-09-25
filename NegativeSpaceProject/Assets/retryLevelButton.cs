using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryLevelButton : MonoBehaviour
{
    public static int playerLevelNum;

    public void retryLevel(){
        
        string newLevel = "Level"+playerLevelNum;
        SceneManager.LoadScene(newLevel);
    }

}
