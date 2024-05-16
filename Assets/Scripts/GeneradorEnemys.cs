using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemys : MonoBehaviour
{
    public GameObject _prefabEnemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GeneraEnemy", 1, 2);
    }
    private void GeneraEnemy()
    {

        {
            GameObject enemy = Instantiate(_prefabEnemy); 
            enemy.transform.position = transform.position;
        }
    }
    public void PararGen()
    {
        CancelInvoke("GeneraEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
