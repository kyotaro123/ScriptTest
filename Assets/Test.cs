﻿using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic(int damagic)
    {
        if (this.mp > 4)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + (this.mp - damagic) + "。");
            // 残りMPを減らす
            this.mp -= damagic;
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);


        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }


        
        // 配列を初期化する
        int[] array = { 31, 41, 59, 26, 53};

        // 配列の要素を順に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素を逆順に表示する
        for (int i = 4; i > -1; i--)
        {
            Debug.Log(array[i]);
        }

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}