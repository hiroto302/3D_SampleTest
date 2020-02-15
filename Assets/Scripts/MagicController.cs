using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicController : MonoBehaviour

{
    public GameObject magicPrefab;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(magicPrefab, gameObject.transform.position, Quaternion.identity,gameObject.transform);
        }
    }
}
