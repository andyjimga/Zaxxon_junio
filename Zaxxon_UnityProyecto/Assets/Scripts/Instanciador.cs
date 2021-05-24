using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField] GameObject columna;
    Vector3 despl;
    float desplX;
    float desplY;
    float desplZ;
    float rotateZ;
    private float velxSeg = 1f;
    private int n;

    void Start()
    {
        StartCoroutine("columnRegulator");
        InitialColumns();
        

    }

    void Update()
    {

    }

    void ColumnGeneration(float desplZ = 0)
    {

        desplX = Random.Range(-5f, 5f);
        desplY = Random.Range(0f, 10f);
        despl = new Vector3(desplX, desplY, desplZ);
        Instantiate(columna, transform.position + despl, Quaternion.identity); //apuntar

    }

    IEnumerator columnRegulator() //apuntar; el IEnumerator, el while true para el bucle infinito y el yeld return con sus componentes para controlar el tiempo en las corrutinas
    {
        while (true)
        {
            ColumnGeneration();
            yield return new WaitForSeconds(velxSeg);

        }


    }

    void InitialColumns()
    {

        for (n = 10; n < 170; n = n + 10)
        {

            ColumnGeneration(-n);


        }


    }
}


