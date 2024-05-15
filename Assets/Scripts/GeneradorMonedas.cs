using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMoneda : MonoBehaviour
{
    public GameObject prefabMoneda;
    public float tiempoEntreGeneraciones = 4f;
    private float tiempoUltimaGeneracion;

    void Start()
    {
        tiempoUltimaGeneracion = Time.time;
    }

    void Update()
    {
        if (Time.time - tiempoUltimaGeneracion > tiempoEntreGeneraciones)
        {
            GenerarMoneda();
            tiempoUltimaGeneracion = Time.time;
        }
    }

    void GenerarMoneda()
    {
        GameObject moneda = Instantiate(prefabMoneda);
        moneda.transform.position = transform.position;
    }
}