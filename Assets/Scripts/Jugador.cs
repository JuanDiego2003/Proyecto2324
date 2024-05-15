using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Jugador : MonoBehaviour
{
    private float _vel;
    private int _numEnemigosTocados;
    private int _numMonedasTocadas;
    private int _numEscudos;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 8f;
        _numEnemigosTocados = 0;
        _numMonedasTocadas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float direccionIndicadaX = Input.GetAxisRaw("Horizontal");
        float direccionIndicadaZ = Input.GetAxisRaw("Vertical");

        Vector3 direccionIndicada = new Vector3(direccionIndicadaX, 0, direccionIndicadaZ).normalized;

        transform.position += direccionIndicada * (_vel * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision ObjetoTocdo)
    {

        if (ObjetoTocdo.gameObject.CompareTag("Enemigo"))
        {
            ObjetoTocdo.gameObject.GetComponent<Enemy>().DestruirEnemigo();
            if (_numEscudos != 0)
            {
                _numEscudos--;
                string TextEscudos = "Escudos: " + _numEscudos;
                GameObject.Find("EscudoJugador").GetComponent<TMPro.TextMeshProUGUI>().text = TextEscudos;
            }
            
            _numEnemigosTocados++;
            string TextEnemigoTocados = "Enemigos tocados: " + _numEnemigosTocados;
            GameObject.Find("EnemigosTocados").GetComponent<TMPro.TextMeshProUGUI>().text=TextEnemigoTocados;
        }
        if (ObjetoTocdo.gameObject.CompareTag("Moneda"))
        {
            _numEscudos++;
            _numMonedasTocadas++;
            string TextEscudos= "Escudos: " + _numEscudos;
            GameObject.Find("EscudoJugador").GetComponent<TMPro.TextMeshProUGUI>().text = TextEscudos;
            string TextMonedasTocadas = "Monedas tocadas:  " + _numMonedasTocadas;
            GameObject.Find("MonedasTocadas").GetComponent<TMPro.TextMeshProUGUI>().text = TextMonedasTocadas;
        }
    }
}