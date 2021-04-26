using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{

    private Vector3 posIni;



    void Start()
    {
        posIni = new Vector3(0, 2,0);
        transform.position = posIni;
    }

    void Update()
    {
        
    }
}
