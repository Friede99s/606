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
            // ���� ����� �ҷ�����
            Debug.Log("Game Over!!");
            gameOverImage.SetActive(true);
            retry.SetActive(true);
            menu.SetActive(true);
            player.SetActive(false);
        }
        else
        {
            // ��ư�� ������ �� Ŀ���� ��ġ�� ���� �ȿ� �ִ� ���ϰ��� �浹 ����Ʈ �߰�
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