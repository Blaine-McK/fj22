using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearPatrolObstacle : Obstacle
{
    public float moveSpeed;
    private bool movingLeft = true;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.parent.Translate(Vector2.left * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Print to console
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Turn!");
            if (movingLeft)
            {
                transform.parent.localEulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;
            }
            else
            {
                transform.parent.localEulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }
        }
    }
}
