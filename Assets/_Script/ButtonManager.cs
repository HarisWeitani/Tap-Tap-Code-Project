using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void hardwareBtn(string level)
    {
        SceneManager.LoadScene(level);
        Debug.Log("Level Hardware");
    }
   
    public void softwareBtn(string level)
    {
        SceneManager.LoadScene(level);
        Debug.Log("Level Software");
    }

}
