using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    private Vector3 velocity;

    public GameObject player; //Das Gameobjekt des Spielers

    public float smoothTimeY; //Zeit zum einstellen der Kamera auf Y
    public float smoothTimeX; //Zeit zum einstellen der Kamera auf X


    void FixedUpdate()
    {

        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX); //ausrechnen der zukünftigen Position der Kamera auf X
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY); //ausrechnen der zukünftigen Position der Kamera auf X

        transform.position = new Vector3(posX, posY, transform.position.z); //ausgabe der Veränderung
    }
}
