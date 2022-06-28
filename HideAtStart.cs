using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAtStart : MonoBehaviour
{
    [Header("Set-Up")]
    [SerializeField] GameObject gameObjectToHide;
    [SerializeField] bool hideRendererOnly = false;


    void Start()
    {
        if(gameObjectToHide != null)
        {
            if (hideRendererOnly)
            {
                Renderer rend = gameObjectToHide.GetComponent<Renderer>();
                rend.enabled = false;
            }
            else
            {
                gameObjectToHide.SetActive(false);
            }
        }
        else
        {
            if (hideRendererOnly)
            {
                Renderer rend = gameObject.GetComponent<Renderer>();
                rend.enabled = false;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }

}
