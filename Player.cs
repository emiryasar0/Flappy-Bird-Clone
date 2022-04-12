using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]

    [SerializeField] private float velocity = 1;

    [Header("Others")]

    [SerializeField] private GameManager gameManager = null;
    private Rigidbody2D myRigidbody = null;
    private Animator myAnimator = null;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * velocity;
            myAnimator.SetTrigger("Fly");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.AddScore();
    }
}
