using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Heal : MonoBehaviour {

    private Transform player;

    private float currentHealth;

    public Slider healthbar; //Lebens anzeige
    public float heal;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        currentHealth = healthbar.value + heal;
        healthbar.value = currentHealth;
        if (currentHealth == 0)
        {
            Application.LoadLevel(0);
        }
    }
}
