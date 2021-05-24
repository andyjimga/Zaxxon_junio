using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnas : MonoBehaviour
{
    float mcQueen;
    EOvariables eOvariables;
    float rotateZ;
    void Start()
    {
        eOvariables = GameObject.Find("EOvariables").GetComponent<EOvariables>();

        rotateZ = Random.Range(0f, 360f);
        transform.Rotate(0f, 0f, rotateZ);

        StartCoroutine("ColumnDestroyer");
    }

    void Update()
    {
        mcQueen = eOvariables.mcQueen;

        transform.Translate(Vector3.back * Time.deltaTime * mcQueen);

    }

    IEnumerator ColumnDestroyer()
    {
        for (; ; ) //es un bucle infinito
        {
            float actPos = transform.position.z; //actPos es posicion actual
            if (actPos <= -10)
            {
                Destroy(gameObject);
            }

            yield return new WaitForSeconds(2);
        }


    }

    
    
}

