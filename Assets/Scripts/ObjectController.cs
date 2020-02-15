using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // オブジェクトの移動スクリプト
public class ObjectController : MonoBehaviour
{
    // 移動変数
    float righitMove = 1.0f;
    float leftMove = -1.0f;
    float forwardMove = 1.0f;
    float backwardMove = -1.0f;
    Vector3 movePower;
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movePower = new Vector3(righitMove/10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movePower = new Vector3(leftMove/10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            movePower = new Vector3(0, 0,forwardMove/10);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movePower = new Vector3( 0, 0, backwardMove/10);
        }

        transform.Translate(movePower);
        movePower = new Vector3(0, 0, 0);
    }
}
