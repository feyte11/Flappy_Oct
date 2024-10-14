using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float jumpForce;

    public Rigidbody2D rb;
    

    private void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce((transform.up * jumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipePart"))
        {
            GameManager.instance.Lose();
        }
    }
}
