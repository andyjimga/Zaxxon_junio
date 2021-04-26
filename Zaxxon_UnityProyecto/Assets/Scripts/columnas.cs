using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnas : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        StartCoroutine("ColumnDestroyer");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    IEnumerator ColumnDestroyer()
    {
        for (; ; )
        {
            float actPos = transform.position.z;
            if (actPos <= -10)
            {
                Destroy(gameObject);
            }

            yield return new WaitForSeconds(2);
        }


    }
}

