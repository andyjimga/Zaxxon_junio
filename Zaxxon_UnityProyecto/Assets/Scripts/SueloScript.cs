using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloScript : MonoBehaviour
{
    [SerializeField] float scrollSpeed;
    EOvariables eOvariables;

    new Renderer renderer;
    void Start()
    {
        eOvariables = GameObject.Find("EOvariables").GetComponent<EOvariables>();
        renderer = GetComponent<Renderer>();
        scrollSpeed = eOvariables.mcQueen;
    }

    
    void Update()
    {
        //transform.Translate(Vector3.back * Time.deltaTime * eOvariables.mcQueen);

        if (eOvariables.alive2)
        {
            float offset = Time.time * scrollSpeed;
            Vector2 despl = new Vector2(0, -offset);
            renderer.material.SetTextureOffset("_MainText", despl);
            renderer.material.SetTextureOffset("_BumpMap", despl);
        }
    }
}
