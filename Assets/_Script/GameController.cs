using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    //public GameObject objectToSpawn;

    
	// Use this for initialization
	void Start () {
        //ngambil variable dari VariableStore
        GameObject variableStorage = GameObject.Find("VariableStorage");
        VariableStore variableStore = variableStorage.GetComponent<VariableStore>();
        
        variableStore.money = 100;
        Debug.Log(variableStore.money);

	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 0.0f;
            //Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));

            Debug.Log("On Screen Click");
        }
	}

    void OnApplicationQuit()
    {

    }

    void Save()
    {
        
    }

    void Load()
    {

    }


}

// turbo
/*Touch myTouch = Input.GetTouch(0);

Touch[] myTouches = Input.touches;
for (int i = 0; i < Input.touchCount; i++)
{
    Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    spawnPosition.z = 0.0f;
    GameObject objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
}
*/
