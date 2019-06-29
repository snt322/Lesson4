using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 2019/06/29
 * ①課題：配列を宣言して出力しましょう
 *              ・要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
 *              ・for文を使い、配列の各要素の値を順番に表示してください
 *              ・for文を使い、配列の各要素の値を逆順に表示してください
 *              
 * ②発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
 *              ・int型の変数mpを宣言し、53で初期化してください
 *              ・mpを消費して魔法攻撃をするMagic関数を作ってください
 *              ・Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
 *              
 *  ①課題はvoid Kadai()に記載。class Testの先頭に定義。void Start()関数の先頭で呼び出し。
 *  ②発展課題はvoid HattenKadai()に記載。void Kadai()の次に定義。 void Start()関数の2番目で呼び出し。
 * 
 */




//9.2 クラスの作り方 および ②発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
public class Boss
{
    int hp    = 100;         // 体力
    int power = 25;          // 攻撃力
    int mp    = 53;          // MP

    int mpSyouhi = 5;        // MP消費

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        string message = "";
        if(mp >= mpSyouhi)
        {
            mp -= mpSyouhi;
            message = "魔法攻撃をした。残りMPは" + mp + "。";
        }
        else
        {
            message = "MPが足りないため魔法攻撃が使えない。";
        }
        Debug.Log(message);
    }

}

public class Test : MonoBehaviour
{
    //①課題：配列を宣言して出力しましょう
    void Kadai()
    {
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 5;
        array[2] = 19;
        array[3] = 0;
        array[4] = -1;

        for(int i=0; i<array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i=(array.Length - 1); i>=0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    //②発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
    void HattenKadai()
    {
        Boss boss = new Boss();
        for(int i=0; i<11; i++)
        {
            boss.Magic();
        }
    }


    void Hello()
    {
        Debug.Log("8.1 引数も返り値もない関数");
        Debug.Log("Hello, UnityChan");
    }

    void Goodbye()
    {
        Debug.Log("練習：「Goodbye, UnityChan」とコンソールに表示するだけのGoodbye関数を作ってStart関数から呼び出してみましょう。");
        Debug.Log("Goodbye, UnityChan");
    }

    void HelloName(string name)
    {
        Debug.Log("8.2 引数があり返り値のない関数");
        Debug.Log("Hello, " + name);
    }

    int Add(int a, int b)
    {
        Debug.Log("8.3 引数と返り値のある関数");
        int c = a + b;
        return c;
    }

    int Add(int a, int b, int d)
    {
        Debug.Log("練習：Add関数に3つ目のint型の引数を追加して引数の合計値を求めて返すように修正してみましょう。また、Start関数から3つの引数を渡してAdd関数を呼び出してみましょう。");
        int c = a + b + d;
        return c;
    }




    // Use this for initialization
    void Start () {

        //①課題：配列を宣言して出力しましょう
        Debug.Log("①課題：配列を宣言して出力しましょう");
        Kadai();

        //②発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
        Debug.Log("②発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう");
        HattenKadai();



        Debug.Log("----------------------------------------------------");
        Debug.Log("3.3 文字列を表示するスクリプトを作ろう");
        Debug.Log("Hello, World");

        Debug.Log("----------------------------------------------------");
        Debug.Log("4.2 変数を使ってみよう");
        {
            int score;
            score = 150;
            Debug.Log(score);
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("4.3 変数を使って計算しよう");
        {
            int a = 3;
            int b = 4;
            int c = a + b;
            Debug.Log(c);
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("5. 制御文");

        Debug.Log("----------------------------------------------------");
        Debug.Log("5.1 if文を使おう");
        {
            int money = 200;
            if (money >= 100)
            {
                Debug.Log("ポーションを買う");
            }
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("5.2 if〜else文を使おう");
        {
            int money = 50;
            if (money >= 100)
            {
                Debug.Log("ポーションを買う");
            }
            else
            {
                Debug.Log("武器を売る");
            }
        }

        Debug.Log("練習：int money = 50;をint money = 200;に書き換えるとif文の条件を満たすため、ポーションを買うと表示されることを確かめてみましょう。");
        {
            int money = 200;
            if (money >= 100)
            {
                Debug.Log("ポーションを買う");
            }
            else
            {
                Debug.Log("武器を売る");
            }
        }




        Debug.Log("----------------------------------------------------");
        Debug.Log("5.3 if〜else if〜else文を使おう");
        {
            int money = 100;
            if (money <= 50)
            {
                Debug.Log("武器を売る");
            }
            else if (money >= 200)
            {
                Debug.Log("武器を買う");
            }
            else
            {
                Debug.Log("ポーションを買う");
            }
        }

        Debug.Log("練習：moneyの値を変えると、表示内容が変わることを確認してみましょう。");
        {
            int money = 1220;
            if (money <= 50)
            {
                Debug.Log("武器を売る");
            }
            else if (money >= 200)
            {
                Debug.Log("武器を買う");
            }
            else
            {
                Debug.Log("ポーションを買う");
            }
        }



        Debug.Log("----------------------------------------------------");
        Debug.Log("5.4 三項演算子");
        {
            int num = 1;
            int val = (num == 1) ? -100 : 100;
            Debug.Log(val);
        }

        Debug.Log("練習：上の三項演算子を使ったスクリプトをif〜else文で書くと以下の通りになることを確認してみましょう。");
        {
            int val;
            int num = 1;
            if (num == 1)
            {
                val = -100;
            }
            else
            {
                val = 100;
            }
            Debug.Log(val);
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("5.5 スコープ");
        {
            int a = 3;
            if (a == 3)
            {
                int b = 5;
            }
            //Debug.Log(b);                     //エラー
        }
        Debug.Log("練習：Debug.Log( b );をif文のブロック内に入れるとコンパイルが通ることを確認してみましょう。");
        {
            int a = 3;
            if (a == 3)
            {
                int b = 5;
                Debug.Log(b);
            }
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("6. for文");
        {
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(i);
            }
        }
        Debug.Log("練習：for文の条件式（i < 5;）を変えると、出力が変化することを確認してみましょう。-");
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log(i);
            }
        }


        Debug.Log("----------------------------------------------------");
        Debug.Log("6.1 合計値を求めるスクリプト");
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Debug.Log(sum);
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("7.3 配列を使ったスクリプト");
        {
            int[] points = new int[5];

            points[0] = 30;
            points[1] = 20;
            points[2] = 50;
            points[3] = 10;
            points[4] = 80;

            for (int i = 0; i < 5; i++)
            {
                Debug.Log(points[i]);
            }
        }

        Debug.Log("練習：配列の宣言をstring[] points = new string[5];に変更し、配列の各要素に文字列を代入して出力を確認してみましょう。");
        {
            string[] points = new string[5];

            points[0] = "abc";
            points[1] = "def";
            points[2] = "ghij";
            points[3] = "klmnoP";
            points[4] = "Q";

            for (int i = 0; i < 5; i++)
            {
                Debug.Log(points[i]);
            }
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("7.4 配列の応用的な書き方");
        {
            int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] >= 50)
                {
                    Debug.Log(points[i]);
                }
            }
        }

        Debug.Log("練習：配列の初期化時に好きな値で要素を追加し、配列の長さを変えても正常に値が出力されることを確認してみましょう。方");
        {
            int[] points = { 30, 20, 50, 10, 80, 15, 60, 100, 423, 31, 1, 5 };

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] >= 50)
                {
                    Debug.Log(points[i]);
                }
            }
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("8. 関数");

        Debug.Log("----------------------------------------------------");
        Debug.Log("8.1 引数も返り値もない関数");
        Hello();
        Debug.Log("練習：「Goodbye, UnityChan」とコンソールに表示するだけのGoodbye関数を作ってStart関数から呼び出してみましょう。");
        Goodbye();

        Debug.Log("----------------------------------------------------");
        Debug.Log("8.2 引数があり返り値のない関数");
        HelloName("Unity");

        Debug.Log("----------------------------------------------------");
        Debug.Log("8.3 引数と返り値のある関数");
        {
            int num = Add(3, 6);
            Debug.Log(num);
        }
        Debug.Log("練習：Add関数に3つ目のint型の引数を追加して引数の合計値を求めて返すように修正してみましょう。また、Start関数から3つの引数を渡してAdd関数を呼び出してみましょう。");
        {
            int num = Add(3, 6, 3);
            Debug.Log(num);
        }

        Debug.Log("----------------------------------------------------");
        Debug.Log("9. クラス");

        Debug.Log("----------------------------------------------------");
        Debug.Log("9.3 クラスの使い方");
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);

        Debug.Log("練習：新しくBossクラスのmidboss変数を作り、Attack関数やDefence関数を呼び出してみましょう。");
        Boss midboss = new Boss();
        midboss.Attack();
        midboss.Defence(65);

        Debug.Log("----------------------------------------------------");
        Debug.Log("9.4 アクセス修飾子");

        Debug.Log("----------------------------------------------------");
        Debug.Log("9.5 thisキーワード");


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
