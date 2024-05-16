using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMoneda : MonoBehaviour
{
    public GameObject prefabMoneda;
    public float tiempoEntreGeneraciones = 4f;

    void Start()
    {
        InvokeRepeating("GenerarMoneda", 1, tiempoEntreGeneraciones);
    }

    void GenerarMoneda()
    {
            GameObject moneda = Instantiate(prefabMoneda);
            moneda.transform.position = transform.position;
    }

    public void PararGen()
    {
        CancelInvoke("GenerarMoneda");
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}