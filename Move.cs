using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Movement Settings")]

    [SerializeField] private float speed = 2;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
