using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterHouse : MonoBehaviour {

    //Referenzen
    private Transform player;

    //Strings
    public string levelToLoad;

    //Bools
    private bool showText;

    //Vektors
    public Vector2 textPosition;

    public GUIStyle textStyle;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       
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

    void OnGUI() 
    {
        if(showText)
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(textPosition.x, textPosition.y, 300, 300), "E to Enter!", textStyle);
        }
    }

    void Update()
    {
        if(showText)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel(levelToLoad);
            }
        }
    }
}
