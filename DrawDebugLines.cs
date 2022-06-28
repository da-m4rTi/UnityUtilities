using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawDebugLines : MonoBehaviour
{
    [Header("Set-Up")]
    [SerializeField] bool drawSphere = false;
    [SerializeField] bool drawCube = false;
    [SerializeField] float radius = 3f;


    private void Start()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        if(drawSphere)
            Gizmos.DrawWireSphere(transform.position, radius);

        if(drawCube)
            Gizmos.DrawWireCube(transform.position, new Vector3(radius, radius, radius));
    }
}
