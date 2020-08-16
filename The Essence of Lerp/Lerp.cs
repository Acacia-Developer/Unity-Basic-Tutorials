using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    [SerializeField] private Transform a;
    [SerializeField] private Transform b;
    [SerializeField] private float t;

    void Update()
    {
        transform.position = Vector3.Lerp(a.position, b.position, t);
    }
}
