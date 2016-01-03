using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    //References
    public Rigidbody2D rb2d;       //Rigidbody des Spielers

    //Floats
    public float speed;            //Geschwindigkeit des Spielers
    public float maxSpeed;         //max. Geschw. des Spielers

    public float jumpForce;        //Sprungkraft des Spielers

    //Bools
    public bool grounded;

    void Start()
    {
        //Verbinde Referenzen
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");      //h = [-1;1], weil: Input.GetAxis("Horizontal") ist der Input auf den Tasten A und D (=> -1 und 1 sind die Maximalwerte!)


        //Movement
        if(h > 0.1f)                                //Bewegt Spieler nach Rechts
        {
            rb2d.transform.Translate(Vector2.right * speed * Time.deltaTime); //Bewegt 
            rb2d.transform.localScale = new Vector2(2, 2);  //Dreht spieler nach rechts

            if(rb2d.velocity.x >= maxSpeed)                 //Wenn Geschw. >= maxSpeed setzt es die Geschw. auf den maxSpeed
            {
                rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y); 
            }
        }

        if (h < -0.1f)                                //Bewegt Spieler nach Links
        {
            rb2d.transform.Translate(Vector2.left * speed * Time.deltaTime); //Bewegt 
            rb2d.transform.localScale = new Vector2(-2, 2);  //Dreht spieler nach links

            if (rb2d.velocity.x <= -maxSpeed)                 //Wenn Geschw. <= -maxSpeed setzt es die Geschw. auf den -maxSpeed
            {
                rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
            }
        }

        //Springen
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb2d.AddForce(Vector2.up * jumpForce);
        }

    }
}
