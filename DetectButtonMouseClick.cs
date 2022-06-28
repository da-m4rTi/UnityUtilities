//Attatch this script to a Button GameObject

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class DetectButtonMouseClick : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent leftClick;
    public UnityEvent middleClick;
    public UnityEvent rightClick;

    //Detect if a click occurs
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + " Game Object Left Clicked!");
            leftClick.Invoke();
        }
            
        if (eventData.button == PointerEventData.InputButton.Middle)
        {
            Debug.Log(name + " Game Object Middle Clicked!");
            middleClick.Invoke();
        }
            
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log(name + " Game Object Right Clicked!");
            rightClick.Invoke();
        }
    }
}