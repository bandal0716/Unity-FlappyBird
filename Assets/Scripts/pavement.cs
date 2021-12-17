using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pavement : MonoBehaviour
{
    Vector2 posIniziale;
    void Start()
    {
        posIniziale = transform.position;
    }
    
    void Update()
    {
        if(!GameController.gameover)
        {
            if (transform.position.x >= -0.76f)
                transform.position = new Vector2(transform.position.x
                    - 2f * Time.deltaTime, transform.position.y);
            else
                transform.position = posIniziale;
        }
 
    }
}
