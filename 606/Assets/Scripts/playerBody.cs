using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBody : MonoBehaviour
{
    GameManager manager;
    private void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)    // EnemyBlock
        {
            if(collision.tag == "1Block")
            {
                if (playerHP.health[0] > 0)
                    playerHP.health[0] -= 1;
                else
                    manager.gameOver = true;
            }
            else if(collision.tag == "2Block")
            {
                if (playerHP.health[1] > 0)
                    playerHP.health[1] -= 1;
                else
                    manager.gameOver = true;
            }
            else if(collision.tag == "3Block")
            {
                if (playerHP.health[2] > 0)
                    playerHP.health[2] -= 1;
                else
                    manager.gameOver = true;
            }
            else if(collision.tag == "4Block")
            {
                if (playerHP.health[3] > 0)
                    playerHP.health[3] -= 1;
                else
                    manager.gameOver = true;
            }
        }
    }
}
