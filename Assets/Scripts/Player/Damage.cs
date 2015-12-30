using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Damage : MonoBehaviour {

    private float currentHealth;

    public Slider healthbar; //Lebens anzeige
    public float damage;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        currentHealth = healthbar.value - damage;
        healthbar.value = currentHealth;
        if (currentHealth == 0)
        {
            Application.LoadLevel(0);
        } 
    }

    void OnTriggerExit2D(Collider2D col)
    {

    }
}
