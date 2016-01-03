using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Damage : MonoBehaviour {

    public Slider healthbar; //Lebens anzeige
    public float damage; //Um wieviele Punkte reduziert wird
    public GameObject DeadPanel; //Panel das angezeigt werden soll wenn man stirbt

    void OnTriggerEnter2D(Collider2D col)
    {

        healthbar.value = healthbar.value - damage;

        if (healthbar.value == 0)
        {
                DeadPanel.SetActive(true);
        } 
    }
}
