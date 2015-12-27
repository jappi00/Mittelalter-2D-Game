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
}
