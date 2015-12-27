using UnityEngine;
using System.Collections;
using UnityEngine.UI;
   

public class Main_menu : MonoBehaviour {
    
    public void ExitGame() {
       Application.Quit();
       Debug.Log ("EXIT");
    }
    public void ChangeScene (int sceneChangeTo){
        Application.LoadLevel(sceneChangeTo);
        Debug.Log("change scene");
    }
    public void menuChangeTo(GameObject objektToChange){
        if (objektToChange.activeSelf)
        {
            objektToChange.active = false;
        }
        else
        {
            objektToChange.active = true;
        }
    }
}
