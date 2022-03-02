using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject gameOverImage, retry, menu, player;

    private void Start()
    {
        gameOverImage.SetActive(false);
        retry.SetActive(false);
        menu.SetActive(false);
        player.SetActive(true);
    }
    void Update()
    {
        if(gameOver)
        {
            // 게임 종료씬 불러오기
            Debug.Log("Game Over!!");
            gameOverImage.SetActive(true);
            retry.SetActive(true);
            menu.SetActive(true);
            player.SetActive(false);
        }
        else
        {
            // 버튼을 눌렀을 때 커서가 위치한 범위 안에 있는 블록과의 충돌 이팩트 추가
        }
    }

    public void ChangeToGamingScene()
    {
        SceneManager.LoadScene("Gaming");
    }
    public void ChangeToTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
}
