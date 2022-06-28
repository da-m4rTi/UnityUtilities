using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAtSpeed : MonoBehaviour
{
    [SerializeField] private float degreeStep = 45f;

    private void Update()
    {
        float step = degreeStep * Time.deltaTime;
        transform.Rotate(Vector3.forward, step);
    }
}
