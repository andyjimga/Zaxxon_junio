using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EOvariables : MonoBehaviour
{
    public float mcQueen;
    [SerializeField] Text distance;
    [SerializeField] Text nivel;
    float intervalo;
    float dist;
    float segundos;
    float levelRise;
    float level;

    public bool alive2;
    Nave nave;

    void Start()
    {

        intervalo = 0.1f;
        dist = 1;
        segundos = 0f;
        level = 1;
        mcQueen = 10f;

        nave = GameObject.Find("NaveBola").GetComponent<Nave>();

        alive2 = nave.alive;
        StartCoroutine("levelIncrease");
        StartCoroutine("velocity");
    }

    void Update()
    {
        contador();
        viva();
        alive2 = nave.alive;
    }

    void contador()
    {
        intervalo -= Time.deltaTime;
        if (intervalo <= 0)
        {
            intervalo = 1;
            segundos = segundos + 1;
        }

    } 

    void viva()
    {
        if (mcQueen > 0)
        {
            dist = segundos * mcQueen;
            distance.text = "Distance: " + dist + " mts";
        }

        
    }

    IEnumerator levelIncrease()
    {
        while (alive2) // es lo mismo que (alive2 == true)
        { 
            nivel.text = "Level " + level;
            yield return new WaitForSeconds(10f);
            level ++;
        }
    }
    IEnumerator velocity()
    {
        while(true)
        {
            yield return new WaitForSeconds(10f);
            if (alive2) //hacerlo bien con un metodo que interrumpa corrutinas
            {
                mcQueen = mcQueen + 10;
            }
        }
    }
}
