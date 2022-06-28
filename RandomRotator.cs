
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    [Header("Set-Up")]
    [SerializeField] List<Transform> transformsToRotate = new List<Transform>();
    [SerializeField] bool rotate = true;
    [SerializeField] bool scale = false;

    void Start()
    {
        if(transformsToRotate.Count > 0)
        {
            if(rotate)
                foreach(Transform t in transformsToRotate)
                {
                    t.Rotate(0, Random.Range(0, 360), 0);
                }
        }
        else
        {
            if (rotate)
                transform.Rotate(0, Random.Range(0, 360), 0);
        }
    }


}
