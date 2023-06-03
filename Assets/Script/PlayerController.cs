using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    [SerializeField] private float speed;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += (horizontalInput * Vector3.forward * speed * Time.deltaTime);
    }

}

