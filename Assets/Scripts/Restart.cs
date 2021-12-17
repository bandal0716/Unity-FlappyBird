using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void ClickRestart()
    {
        //게임오버가 아닐때 비활성화
        GameController.gameover = false;
        SceneManager.LoadScene(0);
    }
}
