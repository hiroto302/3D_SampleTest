using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerFPS : MonoBehaviour
{
    Rigidbody m_Rigidbody;

	void Start()
	{
		// 自分のRigidbodyを取ってくる
		m_Rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		// 十字キーで首を左右に回す
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
		}

		// WASDで移動する
		float x = 0.0f;
		float z = 0.0f;

		if (Input.GetKey(KeyCode.D))
		{
			x += 1.0f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			x -= 1.0f;
		}
		if (Input.GetKey(KeyCode.W))
		{
			z += 1.0f;
		}
		if (Input.GetKey(KeyCode.S))
		{
			z -= 1.0f;
		}

        // rigidbody の速度を直接いじる
		// m_Rigidbody.velocity = new Vector3(x, 0.0f, z);
        // 上記の記述だとカメラの向きと移動方向が合わないので下記のように記述する
        // Debug.Log(transform.forward + ": forward");
        // Debug.Log(transform.right + ": right");
        // Debug.Log(m_Rigidbody.velocity + ": velocity");

        m_Rigidbody.velocity = z * transform.forward + x * transform.right;
	}
}
