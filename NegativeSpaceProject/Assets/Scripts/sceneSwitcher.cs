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
        SceneManager.LoadScene(newLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
