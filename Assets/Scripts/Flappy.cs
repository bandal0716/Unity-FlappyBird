using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    public AudioClip[] audioClips;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        //마우스 왼쪽클릭을 누르면 velocity의 y값을 준다.
        if (Input.GetMouseButtonDown(0) && !GameController.gameover)
        {   
            //누르면 0번 오디오 클립 실행
            audioSource.PlayOneShot(audioClips[0]);
            rb.velocity = new Vector2(0f, 7f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //파이프에 닿았을때 1번 오디오클립 실행
        audioSource.PlayOneShot(audioClips[1]);
        GameController.gameover = true;
        //gameover와 플레이어가 충돌되었을때
        gameover.SetActive(true);
        restart.SetActive(true);
    }
}
