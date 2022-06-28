using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRandomizer : MonoBehaviour
{

    private void Start()
    {
        Randomize();
    }

    void Randomize()
    {
        int childCount = transform.childCount;
        int random = Random.Range(0, childCount);

        for(int i = 0; i<childCount; i++)
        {
            if(i != random)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
