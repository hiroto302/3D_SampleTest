using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // // キャラクター操作に関して
    // CharacterController characterController;
    // // キャラクターの速度
    // Vector3 velocity;
    // // キャラクターの歩くスピード
    // [SerializeField]
    // private float walkSpeed = 2f;
    // // キャラクターの走るスピード
    // [SerializeField]
    // private float runSpeed = 4f;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     characterController = GetComponent<CharacterController>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     // キャラクターの操作機能のみの記述
    //     // キャラクターが接地しているかどうか
    //     if(characterController.isGrounded)
    //     {
    //         velocity = Vector3.zero; // Vector3.zeroを入れて速度を0にする
    //         var input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));  //横軸の入力,縦軸の入力
    //         // input.magnitudeで入力（ベクトル）の長さを取得
    //         if(input.magnitude > 0.1f) {
    //             //transform.LookAt 引数で指定したベクトルの方向を向かせるメソッド
    //             // input.normalizedで入力の単位ベクトル（長さが1のベクトルで方向を得る）を足すことで現在の位置に入力した方向を足して、その方向を向かせるようにします。
    //             transform.LookAt(transform.position + input.normalized);
    //         }
    //     }
    //     velocity.y += Physics.gravity.y * Time.deltaTime;
    //     characterController.Move(velocity * Time.deltaTime);
    // }
    private CharacterController controller;

    [SerializeField]
    private float speed = 3.0f;
    private float gravity = 9.8f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        CalculateMove();
    }

    void CalculateMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = direction * speed;
        velocity.y -= gravity;
        velocity = transform.transform.TransformDirection(velocity);
        // controller.Move(velocity * Time.deltaTime);
    }
}