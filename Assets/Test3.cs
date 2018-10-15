using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53; //MP

    // 魔法攻撃の関数
    public void Magic()
    {
 
        if(mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りＭＰは" + mp);
        }
        else
        {
            Debug.Log("ＭＰが足りないため魔法が使えない");
        }
    }

   

}

public class Test3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 魔法攻撃用の関数を呼び出し、１２回繰り返す
        for (int i = 0; i < 12; i++)
            lastboss.Magic();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
