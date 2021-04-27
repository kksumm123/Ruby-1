using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamController : MonoBehaviour
{
    public GameObject Ruby;

    void Update()
    {
        //Vector2 position = transform.position;

        //position.x = Ruby.transform.position.x;
        //position.y = Ruby.transform.position.y;
        Vector2 dir = Ruby.transform.position - this.transform.position;
        Vector2 moveVector = new Vector2(dir.x, dir.y);
        this.transform.Translate(moveVector);
    }
}
