using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    [SerializeField]
    Vector3 rotationAmount = new Vector3(0f, 15f, 0f);

    public void RotatePlatform()
    {
        transform.Rotate(rotationAmount);
    }
}