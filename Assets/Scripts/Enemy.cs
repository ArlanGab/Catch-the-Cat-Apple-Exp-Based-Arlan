using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Vector3 velocity = new Vector3(0, -0.5f, 0);
    private Transform selfTransform;

    void Start()
    {
        this.selfTransform = this.transform;
    }

    private const float GAME_OVER_WHEN_REACHED = -8f;

    void Update()
    {
        Vector3 displacement = velocity * Time.deltaTime;
        this.selfTransform.Translate(displacement);

        if (this.selfTransform.position.y < GAME_OVER_WHEN_REACHED)
        {
            Destroy(this.gameObject);
        }
    }

    /**
     * Sets the velocity. Some other controller will call this function so that the velocities of enemies are different.
     */
    public void SetVelocity(Vector3 v)
    {
        velocity = v;
    }
}
