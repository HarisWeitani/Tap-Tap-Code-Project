using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //nanti di taro di button masing masing item
    public int indexCPU;
    public int indexGPU;
    public int indexPSU;
    public int indexRAM;

    //buat kasih index ke berapa nanti biar di access di gamecontroller
    //nanti tiap button di ganti di inspector
    public void index(int index)
    {
        indexCPU = index;
    }


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
