using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Damage : MonoBehaviour {

    private Transform player;

    private float currentHealth;

    public Slider healthbar; //Lebens anzeige
    public float damage;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
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
