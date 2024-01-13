using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private GameObject player;
    public float speed = 10f;
    private Vector2 targetPos;
    private bool isMoving = false;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (!isMoving)
            {
                StartCoroutine(MoveToPosition(player.transform, targetPos, speed));
            }
        }
    }

    IEnumerator MoveToPosition(Transform transform, Vector2 position, float speed)
    {
        isMoving = true;
        while ((Vector2)transform.position != targetPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            yield return null;
        }
        isMoving = false;
    }
}