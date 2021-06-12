using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    private Vector3 posIni;
    [SerializeField] Vector3 posDest = new Vector3(0, 1, 0);
    private Vector3 finPos;
    float posX;
    float posY;
    float mcQueen;

    EOvariables eOvariables;
    new Renderer renderer;
    public bool alive = true;



    void Start()
    {
        posIni = new Vector3(0, 0, 0);
        transform.position = posIni;
        eOvariables = GameObject.Find("EOvariables").GetComponent<EOvariables>();
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        MovNave();
        mcQueen = eOvariables.mcQueen;

    }


    void MovNave()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");
        
        if((posX >= -4.5 || desplX > 0) && (posX <= 4.5 || desplX < 0))
        {
            transform.Translate(Vector2.right * desplX * Time.deltaTime * mcQueen);

        }

        if((posY >= -4.5 || desplY > 0) && (posY <= 4.5 || desplY < 0))
        {
            transform.Translate(Vector2.up * desplY * mcQueen * Time.deltaTime);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstaculo")
        {
            renderer.enabled = false;
            alive = false;
            eOvariables.mcQueen = 0;
        }
    }
}
