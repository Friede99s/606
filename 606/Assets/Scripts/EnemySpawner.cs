using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Block;
    private int[] angles = { 45, 135, 225, 315 };
    private bool[] randoms = { true, false, false, false };
    public float cooltime;
    private float curtime;
    private float x, y, angle;
    private int index;
    Vector2 direction;
    void Start()
    {
        curtime = cooltime;
    }
    
    void Update()
    {
        if(curtime <= 0)
        {
            curtime = cooltime;
            direction = new Vector2(x, y).normalized;
            index = (int)Random.Range(0, 4);
            angle = angles[index];
            x = Mathf.Cos(angle*Mathf.Deg2Rad);
            y = Mathf.Sin(angle*Mathf.Deg2Rad);
            GameObject go = Instantiate(Block, new Vector3(x, y, 0).normalized * 8, Quaternion.Euler(0, 0, 0));
            switch(index)
            {
                case 0:
                    go.tag = "1Block";
                    if (randoms[Random.Range(0, randoms.Length)])
                    {
                        go.layer = 7;   // HealBlock
                        go.GetComponent<SpriteRenderer>().material.color = Color.green;
                    }
                    break;
                case 1:
                    go.tag = "2Block";
                    if (randoms[Random.Range(0, randoms.Length)])
                    {
                        go.layer = 7;   // HealBlock
                        go.GetComponent<SpriteRenderer>().material.color = Color.green;
                    }
                    break;
                case 2:
                    go.tag = "3Block";
                    if (randoms[Random.Range(0, randoms.Length)])
                    {
                        go.layer = 7;   // HealBlock
                        go.GetComponent<SpriteRenderer>().material.color = Color.green;
                    }
                    break;
                case 3:
                    go.tag = "4Block";
                    if (randoms[Random.Range(0, randoms.Length)])
                    {
                        go.layer = 7;   // HealBlock
                        go.GetComponent<SpriteRenderer>().material.color = Color.green;
                    }
                    break;
            }
        }
        else
        {
            curtime -= Time.deltaTime;
        }
    }
}
