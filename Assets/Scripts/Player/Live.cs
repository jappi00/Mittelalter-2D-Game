using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Live : MonoBehaviour {

    public Slider healthbar; //Lebens anzeige

    public int currentLife; //Anfangs Leben

    public int minLive; // Minimales Leben Standard = 0
    public int maxLive; // Maximales Leben Standard = 100

	// Use this for initialization
	void Start () {
        if (minLive >= maxLive)
        {
            Debug.LogError("Das minimale Leben ist grösser oder gleich zum maximalen Leben, das Maximale wird zu 100 und das minimale zu 0 gesetzt");
            minLive = 0;
            maxLive = 100;
            
        }
        if (minLive == currentLife)
        {
            Debug.LogError("Das momentane Leben ist gleich dem minimalen Leben also ist man sofort tot!");
        }
        healthbar.minValue = minLive;
        healthbar.maxValue = maxLive;
        healthbar.value = currentLife;
	}
}
