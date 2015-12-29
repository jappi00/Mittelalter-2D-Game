using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterHouse : MonoBehaviour {

    //Referenzen
    private Transform player;
    private GameObject enterText;

    //Strings
    public string levelToLoad;

    //Bools
    private bool showText;

    //Vektors
    public Vector2 textPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enterText = GameObject.FindGameObjectWithTag("ShowEnterText");

        enterText.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            showText = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        showText = false;
    }

    void Update()
    {
        if(showText)
        {
            enterText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel(levelToLoad);
            }
        }else
        {
            enterText.SetActive(false);
        }
    }
}
