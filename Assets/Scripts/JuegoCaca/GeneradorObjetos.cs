using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    [SerializeField] public GameObject objetosPosibles;
    public float tiempoEntreGeneraciones = 3f;

    private void Start()
    {
        StartCoroutine(GenerarObjetosAleatorio());
    }

    IEnumerator GenerarObjetosAleatorio()
    {
        while(true)
        {
            
            Instantiate(objetosPosibles, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(tiempoEntreGeneraciones);
        }
    }
}
