using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecogerCaca : MonoBehaviour
{
    public int puntuacion;
    public Text puntuacionText;

    private void Start()
    {
        puntuacion = 0;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 click = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (isobjectself(click))
            {
                Destroy(gameObject);

            }
        }
    }

    private bool isobjectself(Vector2 posision)
    {
        Collider2D collider = GetComponent<Collider2D>();
        if (collider != null)
        {
            return collider.OverlapPoint(posision);
        }
        return false;
    }
}
