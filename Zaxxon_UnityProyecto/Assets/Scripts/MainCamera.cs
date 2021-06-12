using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    [SerializeField] float smoothVelocity;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;

    EOvariables eOvariables;
    

    void Start()
    {
        eOvariables = GameObject.Find("EOvariables").GetComponent<EOvariables>();
    }

    void Update()
    {
        if (eOvariables.alive2)
        {
            smoothVelocity = 1f / eOvariables.mcQueen;
            Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
        }
    }

}
