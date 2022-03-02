using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    float z;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            z = 135;
        else if (Input.GetKeyDown(KeyCode.Slash))
            z = -135;
        else if (Input.GetKeyDown(KeyCode.A))
            z = 45;
        else if (Input.GetKeyDown(KeyCode.Quote))
            z = -45;
        Vector2 len = new Vector2(Mathf.Cos((z+90)*Mathf.Deg2Rad), Mathf.Sin((z+90)*Mathf.Deg2Rad));
        this.transform.rotation = Quaternion.Euler(0, 0, z+225);
        this.transform.position = len.normalized * 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)    // HealBlock
        {
            if (collision.tag == "1Block")
            {
                if (playerHP.health[0] < 3)
                    playerHP.health[0] += 1;
            }
            else if (collision.tag == "2Block")
            {
                if (playerHP.health[1] < 3)
                    playerHP.health[1] += 1;
            }
            else if (collision.tag == "3Block")
            {
                if (playerHP.health[2] < 3)
                    playerHP.health[2] += 1;
            }
            else if (collision.tag == "4Block")
            {
                if (playerHP.health[3] < 3)
                    playerHP.health[3] += 1;
            }
        }
    }
}
