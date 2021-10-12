using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LingkaranMovement : MonoBehaviour
{
    Rigidbody2D rigidbody;

    float horizontal;
    float vertical;

    Vector2 currentVelocity;
    public ScoreCount score;
    public float maxMoveSpeed = 10f;
    public float smoothTime = 0.3f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // gerakan player menggunakan WASD ataupun arrowkey
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // gerakan bola mengikuti mouse, menggunakan smoothdamp sehingga gerakan lebih halus
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(horizontal * maxMoveSpeed, vertical * maxMoveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kotak")
        {
            transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
            score.IncrementScore();
            Destroy(collision.gameObject);
        }
    }
}
