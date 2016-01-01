using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Heal : MonoBehaviour {

    public Slider healthbar; //Lebens anzeige
    public float heal; //Um wieviele Punkte geheilt wird

    
    void OnTriggerEnter2D(Collider2D col) //wenn der Spieler im Bereich des Schadens ist
    {
        healthbar.value = healthbar.value + heal; //Das momentane Leben ist der Wert der Healthbar | Healtbar + Den Wert beim heilen = Healthbar
        Debug.Log(healthbar.value); // Das momentane Leben wird in der Konsole ausgegeben
    }
}
