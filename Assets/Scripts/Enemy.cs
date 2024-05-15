using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float _vel;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 4f;
        Invoke("DestruirEnemic", 4);
    }
    private void DestruirEnemic()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posJugador = GameObject.Find("Jugador").transform.position;

        Vector3 direccioCapJugador = (posJugador - transform.position).normalized;

        transform.position += direccioCapJugador * (_vel * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision ObjetoTocdo)
    {
        if (ObjetoTocdo.gameObject.name == "Jugador")
        {
            DestruirEnemigo();
        }

    }
    public void DestruirEnemigo()
    {
            Destroy(gameObject);
    }

}
