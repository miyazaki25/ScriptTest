using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // 配列を初期化する
        int[] array = { 30, 20, 50, 10, 80 };

        // 配列の要素数のぶんだけ逆順に処理を繰り返す
        for (int i = array.Length - 1; 0 <= i; i--)

        {
            //各要素の値を逆順に表示する
            Debug.Log(array[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
