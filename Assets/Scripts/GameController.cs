using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float spawnTimer;
    float spawnRate = 3f;
    public GameObject pipe;
    public static bool gameover;

    void Update()
    {   
        //게임오버가 아닐때 파이프 스폰
        if(!gameover)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer >= spawnRate)
            {
                spawnTimer -= spawnRate;
                //파이프가 범위에서 랜덤 스폰되도록
                Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));
                Instantiate(pipe, spawnPos, Quaternion.identity);
            }
        }

    }
}
