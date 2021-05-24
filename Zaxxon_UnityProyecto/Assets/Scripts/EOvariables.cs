using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EOvariables : MonoBehaviour
{
    public float mcQueen;

    [SerializeField] Text distance;
    [SerializeField] Text tiempo;
    float intervalo;
    float dist;
    float segundos;

    void Start()
    {
        mcQueen = 10f;

        intervalo = 0.1f;
        dist = 0f;
        segundos = 0f;
        
    }

    void Update()
    {
        contador();
    }
    
    void contador()
    {
        intervalo -= Time.deltaTime;
        if (intervalo <= 0)
        {
            intervalo = 0.1f;
            segundos = segundos + 0.1f;
        }


        dist = segundos * mcQueen;
        distance.text = dist + " mts";
        tiempo.text = "segundos " + segundos;
    }

}
