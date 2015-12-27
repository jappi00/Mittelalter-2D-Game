using UnityEngine;
using System.Collections;
using UnityEngine.UI;
   

public class Main_menu : MonoBehaviour {
    
    //Spiel beenden
    public void ExitGame() {
       Application.Quit();
       Debug.Log ("EXIT");
    }

    //Andere Scene aufrufen
    public void ChangeScene (int sceneChangeTo){
        Application.LoadLevel(sceneChangeTo);
        Debug.Log("change scene");
    }
    //Anderes Menü öffnen
    public void menuChangeTo(GameObject objektToChange){
        //wechsel zu aus
        if (objektToChange.activeSelf)
        {
            objektToChange.SetActive(false);
        }
        //wechsel zu an
        else
        {
            objektToChange.SetActive(true);
        }
    }
}
