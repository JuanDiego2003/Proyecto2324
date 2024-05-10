using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private float _vel;
    // Start is called before the first frame update
    void Start()
    {
        _vel = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        float direccionIndicadaX = Input.GetAxisRaw("Horizontal");
        float direccionIndicadaZ = Input.GetAxisRaw("Vertical");

        Vector3 direccionIndicada = new Vector3(direccionIndicadaX, 0, direccionIndicadaZ).normalized;

        transform.position += direccionIndicada * (_vel * Time.deltaTime);
    }
}
