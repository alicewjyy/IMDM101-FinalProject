using UnityEngine;

public class SetVRPosition : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(-7634, 4, 36800);

    void Start()
    {
        transform.position = startPosition;
    }
}