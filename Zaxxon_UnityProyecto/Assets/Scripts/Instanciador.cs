using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField] GameObject columna;
    Vector3 despl;
    float desplX;
    float desplZ;
    private float velxSeg = 1f;
    private int n;

    // Start is called before the first frame update
    void Start()
    {
        //ColumnGeneration();
        StartCoroutine("columnRegulator");
        InitialColumns();
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ColumnGeneration(float desplZ = 0)
    {

        desplX = Random.Range(-5f, 5f);
        despl = new Vector3(desplX, 0, desplZ);
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


