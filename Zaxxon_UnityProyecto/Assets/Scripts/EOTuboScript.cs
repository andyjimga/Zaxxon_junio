using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EOTuboScript : MonoBehaviour
{
    [SerializeField] GameObject suelo;
    EOvariables eOVariables;
    Vector3 iniPos = new Vector3(0, -5, 50);
    Vector3 iniPos2 = new Vector3(0, -5, 200);
    Vector3 iniPos3 = new Vector3(0, -5, 350);
    float regulator;
    bool alive3;
    void Start()
    {
        
        //StartCoroutine("Generador");
        //Instantiate(suelo, transform.position + iniPos, Quaternion.identity);
        //Instantiate(suelo, transform.position + iniPos2, Quaternion.identity);
        //eOVariables = GameObject.Find("EOvariables").GetComponent<EOvariables>();
        //alive3 = eOVariables.alive2;
    }


    void Update()
    {
        //regulator = 150f / eOVariables.mcQueen;
    }
    IEnumerator Generador() 
    {
        while (eOVariables.alive2)
        {
            yield return new WaitForSeconds(regulator);
            Instantiate(suelo, transform.position + iniPos3, Quaternion.identity);
        }
    }
    
}
