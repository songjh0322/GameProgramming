using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public string name = "로봇";
    public int att = 100;
    public int def = 30;
    void Start()
    {
        print("주인공의 이름은 " + name + "입니다.");
        print("주인공의 공격력은 " + att + "입니다.");
        print("주인공의 방어력은 " + def + "입니다.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
