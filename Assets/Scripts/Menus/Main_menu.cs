using UnityEngine;
using System.Collections;
using UnityEngine.UI;
   

//Reagiert auf Buttons
public class Main_menu : MonoBehaviour {     
    //Schließt das Spiel

    public void ExitGame() {
       Application.Quit();
       Debug.Log ("EXIT");
    }

    //Wechselt zu einer anderen Scene
    public void ChangeScene (int sceneChangeTo){
        Application.LoadLevel(sceneChangeTo);
        Debug.Log("change scene");
    }

    public void ChangePanel(GameObject Objekt )
    {
        Objekt.SetActive(true);
    }
}
