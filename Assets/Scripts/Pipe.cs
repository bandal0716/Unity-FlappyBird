using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    bool howmuch = false;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //GameController가 게임오버가 아닐때 진행
        if(!GameController.gameover)
        {
            transform.position = new Vector2(transform.position.x
            - 2f * Time.deltaTime, transform.position.y);
        }

        if (transform.position.x < -6)
            Destroy(gameObject);

        
        if(!howmuch && transform.position.x < -4)
        {
            audioSource.Play();
            howmuch = true;
            //스코어 점수 추가
            Score.valueScore += 1;
        }

    }
}
