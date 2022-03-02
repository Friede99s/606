using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHP : MonoBehaviour
{
    public Image[] hp = new Image[4];
    const float maxHp = 3;
    public static float[] health = new float[4];
    void Start()
    {
        for (int i=0; i<4; i++)
        {
            health[i] = maxHp;
        }
    }
    
    void Update()
    {
        for(int i=0; i<4; i++)
        {
            hp[i].fillAmount = health[i] / maxHp;
        }
    }
}
