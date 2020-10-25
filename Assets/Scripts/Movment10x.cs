using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment10x : MonoBehaviour
{
    public float speed = 5f;
    public Transform pos1, pos2;
    public Transform startPosition;
    Vector3 nextPosition;

    // Start is called before the first frame update
    void Start()
    {     
        nextPosition = startPosition.position;
    }

    // Update is called once per frame
    
    void Update()
    {
        {
            if (transform.position.x <= pos1.position.x)
            {
                nextPosition = pos2.position;
            }
            if (transform.position.x >= pos2.position.x)
            {
                nextPosition = pos1.position;
            }
            transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
        }

    }
}
