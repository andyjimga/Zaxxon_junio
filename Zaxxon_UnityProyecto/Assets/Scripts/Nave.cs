using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{

    private Vector3 posIni;
    [SerializeField] Vector3 posDest = new Vector3(0, 1, 0);
    private Vector3 finPos;
    

    void Start()
    {
        posIni = new Vector3(0, 2,0);
        transform.position = posIni;
    }

    void Update()
    {
        //MovNaveProvisional();
        MovNave();
    }

    /* void MovNaveProvisional()
     {

         float desplY = Input.GetAxis("Vertical");

         finPos = posIni + posDest * desplY * Time.deltaTime;
         print(finPos);

         posIni = finPos;
         transform.position = posIni;
     }*/

    void MovNave()
    {
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * desplY * Time.deltaTime); //añadir speed

        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * desplX * Time.deltaTime); //añadir speed

    }
}
