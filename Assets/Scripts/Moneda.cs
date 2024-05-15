using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    private float _velocidad;
    private float _tiempoVida = 6f;

    void Start()
    {
        _velocidad = 6f;
        InvokeRepeating("CambiarDireccion", 0f, 2f);
        Invoke("DestruirMoneda", _tiempoVida);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _velocidad * Time.deltaTime);
    }

    void CambiarDireccion()
    {
        Vector3 nuevaDireccion = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
        transform.rotation = Quaternion.LookRotation(nuevaDireccion);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Pared"))
        {
            CambiarDireccion(); // Cambia la dirección al chocar con una pared
        }
    }

    void DestruirMoneda()
    {
        Destroy(gameObject);
    }
}