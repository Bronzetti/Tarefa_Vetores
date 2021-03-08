using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercício1 : MonoBehaviour
{
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(1, 1, 4), Time.deltaTime);
    }
}
