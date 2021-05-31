using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField] GameObject columna;
    EOvariables eOVariables;
    Vector3 despl;
    float desplX;
    float desplY;
    float desplZ;
    float rotateZ;
    private float distColum;
    private int n;

    void Start()
    {
        StartCoroutine("columnRegulator");
        InitialColumns();
        eOVariables = GameObject.Find("EOvariables").GetComponent<EOvariables>();
        

    }

    void Update()
    {
        distColum = 10f / eOVariables.mcQueen;

    }

    void ColumnGeneration(float desplZ = 0)
    {

        desplX = Random.Range(-5f, 5f);
        desplY = Random.Range(-5f, 5f);
        despl = new Vector3(desplX, desplY, desplZ);
        Instantiate(columna, transform.position + despl, Quaternion.identity); //apuntar
    }

    IEnumerator columnRegulator() //apuntar; el IEnumerator, el while true para el bucle infinito y el yield return con sus componentes para controlar el tiempo en las corrutinas
    {
        while (true)
        {
            ColumnGeneration();
            yield return new WaitForSeconds(distColum);

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