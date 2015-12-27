using UnityEngine;
using System.Collections;

public class GroundTrigger : MonoBehaviour {

    //Referenzen
    private Player player;  //Stellt Verbindung zum Spieler her


    void Start()
    {
        player = GetComponentInParent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)       //Wenn der Trigger mit dem Boden in Berührung kommt kann man springen
    {
        player.grounded = true;
    }

    void OnTriggerExit2D(Collider2D col)        //Wenn der Trigger nix berührt kann man nicht springen
    {
        player.grounded = false;
    }
}
