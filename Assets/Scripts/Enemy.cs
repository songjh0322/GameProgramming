using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string name = "또봇";
    public int att = 50;
    public int def = 20;
    void Start()
    {
        print("악당의 이름은 " + name + "입니다.");
        print("악당의 공격력은 " + att + "입니다.");
        print("악당의 방어력은 " + def + "입니다.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
