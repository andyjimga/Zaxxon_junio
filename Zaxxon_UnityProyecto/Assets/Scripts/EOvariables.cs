using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EOvariables : MonoBehaviour
{
    public float mcQueen;

    [SerializeField] Text distance;
    [SerializeField] Text tiempo;
    [SerializeField] Text nivel;
    float intervalo;
    float dist;
    float segundos;
    float levelRise;
    float level;

    void Start()
    {

        intervalo = 0.1f;
        dist = 0f;
        segundos = 0f;
        level = 1;

        StartCoroutine("speedIncrease");
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
            intervalo = 1;
            segundos = segundos + 1;
        }


        dist = segundos * mcQueen;
        distance.text = "Distance: " + dist + " mts";
        tiempo.text = "Time: " + segundos;
    }

    IEnumerator speedIncrease()
    {
        for (; ; )
        {
            nivel.text = level.ToString();
            yield return new WaitForSeconds(10f);
            level = level + 1;
            mcQueen = level * 10f;
        }
    }
}
