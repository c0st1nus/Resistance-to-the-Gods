using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class Sword : MonoBehaviour
{
    [FormerlySerializedAs("PickUpRange")] public float pickUpRange = 10f;
    private GameObject _player;
    public TMP_Text text;
    
    void Start()
    {
        _player = GameObject.Find("Player");
    }
    void Update()
    {
        if (Vector2.Distance(transform.position, _player.transform.position) < pickUpRange)
        {
            text.text = "Press E to pick up sword";
            if (Input.GetKeyDown(KeyCode.E))
            {
                _player.GetComponent<Player>().hasSword = true;
                text.text = "";
                Destroy(gameObject);
            }
        }
        
        else
        {
            text.text = text.text == "Press E to pick up sword" ? "" : text.text;
        }
    }
}
