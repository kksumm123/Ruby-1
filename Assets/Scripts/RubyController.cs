using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    float posX, posY;

    Rigidbody2D rigidbody2d;

    //public int health;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = 1;
    }

    // 화면 갱신될때마다 호출됨 - git테스트중
    void Update()
    {
        //GetKeyDown <- 키를 눌렀을때 최초 1회
        //GetKey    <- 키를 누르고 있는동안 
        //GetKeyUp  <- 키를 땔때 최초 1회
        //float horizontal = 0;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeHealth(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeHealth(-2);
        }

        //float vertical = 0;
        //if (Input.GetKey(KeyCode.W))
        //{
        //    vertical = 1;
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    vertical = -1;
        //}

        //Debug.Log(horizontal + "그리고 다른 부분을 추가 수정했다 - git test중");

        //Vector2 position = transform.position;
        //position.x = position.x + 0.1f * horizontal;
        //position.y = position.y + 0.1f * vertical;
        //transform.position = position;


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rigidbody2d.position;
        position.x += speed * horizontal * Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime;
        
        posX = position.x;
        posY = position.y;
        rigidbody2d.MovePosition(position);
    }
    public float speed = 10.0f;

    public float RubyX()
    {
        return posX;
    }
    public float RubyY()
    {
        return posY;
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
