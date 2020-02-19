using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// VR花火打ち上げのために利用する
public class GetMaximumValue : MonoBehaviour
{
    Vector3 maxHight;
    float maxHightY;

    Vector3 hight;
    float hightY;


    float speedY;
    Rigidbody rigid;

    public GameObject fireworksPrefab;

    void Start()
    {
        // Debug.Log(Mathf.Max(1, 2));
        this.rigid = GetComponent<Rigidbody>();

        // オブジェクトの初期位置
        hight = transform.position;
        hightY = hight.y;


    }

    // Update is called once per frame
    void Update()
    {
        maxHight = transform.position;
        maxHightY = maxHight.y;
        // Debug.Log(maxHightY);


        speedY = rigid.velocity.y;
        // if( 0f > speedY && maxHightY > 3.0f)
        if( 0f > speedY && maxHightY  > hightY + 3.0f)
        {
            Destroy(gameObject);
        }
        // Debug.Log(speedY);
    }

    void OnDestroy()
    {
        Debug.Log("破壊されたよ");
        Instantiate(fireworksPrefab, gameObject.transform.position, Quaternion.identity);

    }
}
