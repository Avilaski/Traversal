using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    Vector3 movementAmount;

    [SerializeField]
    float movementSpeed = 0.5f;

    Vector3 startPosition;
    bool isMoving;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isMoving)
        {
            transform.position = startPosition + movementAmount * Mathf.PingPong(Time.time * movementSpeed, 1f); // Move back and forth 
        }
    }

    public void StartMoving()
    {
        isMoving = true;
    }

    public void StopMoving()
    {
        isMoving = false;
    }
}