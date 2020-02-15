using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    [SerializeField]
    protected GameObject childrenObject;
 
    [SerializeField]
    protected GameObject parentObject;
 
    void Start()
    {
        // オブジェクトの複製 // オブジェクト名(Clone)として生成される
        // Instantiate(childrenObject);
        // prefabで設定した、transformの位置に生成される

        // 取得した戻り値の活用例
        // cloneObject.name = "originObject2"; // クローンしたオブジェクトの名前を変更
        // cloneObject.transform.parent = this.transform; // GameManagerを親に指定
        // cloneObject.transform.position = new Vector3( -1.0f, 1.0f, 0.0f); // 座標を変更

        // GameObject cloneObject = Instantiate (childrenObject, Vector3.zero, Quaternion.identity);
        // cloneObject.transform.parent = gameObject.transform;
        Instantiate(childrenObject, Vector3.zero, Quaternion.identity, gameObject.transform);
        //第四引数を活用して親オブジェクトを指定することも可能


        // 生成後に親オブジェクトを指定 親にしたいオブジェクトのtransformを渡す
        
        // Instantiate(childrenObject, parentObject.transform);
        // 第三引数に、false(親オブジェクトの相対的な位置のグローバル座標) or true(グローバル座標)を渡して座標を指定
        // Instantiate(childrenObject, parentObject.transform, true);

        // Shot();

    }

    void Update()
    {
        
    }

    // Resources.LoadとInstantiate組み合わせて動的生成
    void Shot () {
        GameObject prefab = (GameObject)Resources.Load ("ChildrenCube");
        GameObject cloneObject = Instantiate (prefab, this.transform.position, Quaternion.identity);
    }
}
