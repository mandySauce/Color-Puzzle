using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] pathPoints;
    public float moveSpeed = 5.0f;
    public float pauseTime = 3.0f;

    private int currentPointIndex = 0;
    private int direction = -1;
    private float pauseTimer = 0.0f;

    private void Update()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {
        Vector3 targetPosition = pathPoints[currentPointIndex].position;

        if (pauseTimer > 0)
        {
            pauseTimer -= Time.deltaTime;
            return;
        }

        float distanceToTarget = Vector3.Distance(transform.position, targetPosition);
        float step = moveSpeed * Time.deltaTime;

        // Adjust the step to cover the distance within this frame
        if (step > distanceToTarget)
        {
            step = distanceToTarget;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        if (Vector3.Distance(transform.position, targetPosition) <= 0.1f)
        {
            StartCoroutine(PauseAtWaypoint());

            currentPointIndex += direction;
            if (currentPointIndex >= pathPoints.Length || currentPointIndex < 0)
            {
                direction *= -1;
                currentPointIndex += direction * 2;
            }
        }
    }


    private IEnumerator PauseAtWaypoint()
    {
        pauseTimer = pauseTime;
        yield return null; // This line is necessary to pause the coroutine
    }
}
