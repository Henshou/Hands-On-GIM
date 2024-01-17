using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public Text healthDisplay;
    public GameObject gameOver;

    public Animator animator;


    private void Update()
    {

        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        healthDisplay.text = "health : " + health.ToString();

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y + Yincrement, minHeight, maxHeight));
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y - Yincrement, minHeight, maxHeight));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacle"))
        {
            animator.SetBool("IsHit",true);
        }
    }
    
    private void Stop()
    {
        animator.SetBool("IsHit",false);
    }
}