using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Set-Up")]
    [SerializeField] float timer = 1f;


    void Start()
    {
        Destroy(gameObject, timer);
    }
}
