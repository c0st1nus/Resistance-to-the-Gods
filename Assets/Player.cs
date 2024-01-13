using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public bool hasSword = false;

    private void Update()
    {
        if (hasSword)
        {
            GameObject sword = transform.GetChild(0).GameObject();
            sword.SetActive(true);
        }
    }
}
