using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPerro : MonoBehaviour
{
    [SerializeField] private float velocidadMovimeinto;
    [SerializeField] private Transform[] puntoDeMoviento;
    [SerializeField] private float minDistance;
    private int ramdomNum;

    // Start is called before the first frame update
    private void Start()
    {
        ramdomNum = Random.Range(0, puntoDeMoviento.Length);

    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntoDeMoviento[ramdomNum].position, velocidadMovimeinto * Time.deltaTime);
        if (Vector2.Distance(transform.position, puntoDeMoviento[ramdomNum].position) < minDistance)
        {
            ramdomNum = Random.Range(0, puntoDeMoviento.Length);

        }
    }
}
