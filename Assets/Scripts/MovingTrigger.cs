using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    [SerializeField]
    MovingPlatform platform;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platform.StartMoving();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platform.StopMoving();
        }
    }
}