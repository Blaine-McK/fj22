using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    private bool movingLeft = true;

    public Transform detector;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.parent.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(detector.position, Vector2.down, 1f);
        RaycastHit2D wallInfo = Physics2D.Raycast(detector.position, Vector2.left, 1f);

        if (groundInfo.collider == false)// || wallInfo.collider == true)
        {
            if(movingLeft)
            {
                transform.parent.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;
            } else
            {
                transform.parent.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }

        }
    }
}
