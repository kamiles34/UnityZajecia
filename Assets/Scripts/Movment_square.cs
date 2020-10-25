using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment_square : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform pos1, pos2, pos3, pos4;
    public Transform startPosition;
    Vector3 nextPosition;
    public GameObject cube;


    // Start is called before the first frame update
    void Start()
    {
        nextPosition = startPosition.position;
    }

    // Update is called once per frame

    void Update()
    {
        {
            if (transform.position == pos1.position)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                nextPosition = pos2.position;
                
            }
            if (transform.position == pos2.position)
            {
                cube.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                nextPosition = pos3.position;
            }
            if (transform.position == pos3.position)
            {
                cube.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                nextPosition = pos4.position;
            }
            if (transform.position == pos4.position)
            {
                cube.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                nextPosition = pos1.position;
            }

            transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
        }

    }
}
