using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioData;
    void Start()
    {
        var cubeRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("BUM! Kolizja");
            audioData.Play(0);
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
