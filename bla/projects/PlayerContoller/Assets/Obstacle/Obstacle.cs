using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool patrol;
    private bool movingLeft = true;
    public float moveSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (patrol)
        {
            gameObject.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (movingLeft)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
            }
        }
    }

    // Upon collision with another GameObject
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Print to console
        Debug.Log("Obstacle Hit!");
    }
}
