using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float maxSpeed = 5f;
    float shipBoundary = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Moving the ship 
        Vector3 pos = transform.position;

        //Player input, movement of ship
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        //Setting the boundaries 
        //Vertical boundaries
        if(pos.y+shipBoundary > Camera.main.orthographicSize) {
            pos.y = Camera.main.orthographicSize - shipBoundary;
        }

        if(pos.y-shipBoundary < -Camera.main.orthographicSize) {
            pos.y = -Camera.main.orthographicSize + shipBoundary;
        }

        //Fix on Horizontal boundaries on other screen ratios 
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        //Horizontal boundaries 
        if(pos.x+shipBoundary > widthOrtho) {
            pos.x = widthOrtho - shipBoundary;
        }

        if(pos.x-shipBoundary < -widthOrtho) {
            pos.x = -widthOrtho + shipBoundary;
        }

        //Position update
        transform.position = pos;

    }
}
