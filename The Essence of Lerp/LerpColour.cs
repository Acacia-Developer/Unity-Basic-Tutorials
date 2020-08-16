using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpColour : MonoBehaviour
{
    [SerializeField] private Color a;
    [SerializeField] private Color b;
    [SerializeField] private Color output;
    [SerializeField][Range(0.0f, 1.0f)] private float t;

    void Update()
    {
        output = Color.Lerp(a, b, t);
    }
}
