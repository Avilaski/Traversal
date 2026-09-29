using UnityEngine;

public class RotationTrigger : MonoBehaviour
{
    [SerializeField]
    RotatingPlatform platform;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platform.RotatePlatform();
        }
    }
}