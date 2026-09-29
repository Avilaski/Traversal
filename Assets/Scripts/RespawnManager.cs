using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [SerializeField]
    Transform respawnPoint;

    public void Respawn()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // Disable control when getting tped, prevents player from falling through falltrigger
        controller.enabled = false;

        transform.position = respawnPoint.position;

        controller.enabled = true;

        MovementController movement = GetComponent<MovementController>();

        // Reset player's velocity back to zero, sometimes player gets tped back if jump is held without this
        if (movement != null)
        {
            movement.ResetVelocity();
        }
    }
}