using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Live : MonoBehaviour {

    public Slider healthbar; //Lebens anzeige

    public int currentLife; //Anfangs Leben

    public int minLive; // Minimales Leben Standard = 0
    public int maxLive; // Maximales Leben Standard = 100

	// Überprüfen von den eingegebenen Daten
	void Start () {
        if (minLive >= maxLive) //wenn das maximale Leben kleiner oder gleich dem minimalem Leben ist wird wie unten geschrieben die Werte gesetzt
        {
            Debug.LogError("Das minimale Leben ist grösser oder gleich zum maximalen Leben, das Maximale wird zu 100 und das minimale zu 0 gesetzt");
            minLive = 0;
            maxLive = 100;
            
        }
        if (minLive >= currentLife)//wenn das minimale Leben größer oder Gleich dem jetzigen Leben ist wird ein Fehler ausgegeben
        {
            Debug.LogError("Das momentane Leben ist gleich dem minimalen Leben also ist man sofort tot!");
        }
         
        //Einrichten des Lebensbalken
        healthbar.minValue = minLive;
        healthbar.maxValue = maxLive;
        healthbar.value = currentLife;
	}
}
