using UnityEngine;

public class GiroAutomatico : MonoBehaviour
{
    public float velocidad = 20f;

    void Update()
    {
        transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }
}