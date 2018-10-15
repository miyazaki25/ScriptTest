using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] array = { 30, 20, 50, 10, 80 };

        // 配列の要素数のぶんだけ順番に処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            //各要素の値を順番に表示する
            Debug.Log(array[i]);
        }
  
     
    }



   

    // Update is called once per frame
    void Update()
    {

    }
}