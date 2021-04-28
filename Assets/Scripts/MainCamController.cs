using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamController : MonoBehaviour
{
    public GameObject Ruby;
    //public float posCamZ = -10f;

    void Update()
    {
        //Debug.Log(Ruby.transform.position + ", " + this.transform.position);

        float timeCompensation = Time.deltaTime * 5;

        Vector2 dir = Ruby.transform.position - this.transform.position;

        Vector2 moveVector = new Vector2(dir.x * timeCompensation, dir.y * timeCompensation);
        this.transform.Translate(moveVector);
    }
}
