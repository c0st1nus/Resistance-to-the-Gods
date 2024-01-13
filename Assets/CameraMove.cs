using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 50f;
    public float border = 10.0f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.mousePosition.y >= Screen.height - border)
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.mousePosition.y <= border)
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.mousePosition.x >= Screen.width - border)
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= border)
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
