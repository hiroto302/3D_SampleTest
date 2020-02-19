using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceObject : MonoBehaviour
{
    Rigidbody rigid;
    public float FlyingForce = 680.0f;
    void Start()
    {
        this.rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            this.rigid.AddForce(transform.up * FlyingForce );
            // this.rigid.AddRelativeFor​​ce(transform.up * FlyingForce );
            Debug.Log("Fが押されたよ");
        }
    }
}
