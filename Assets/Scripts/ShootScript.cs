using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public float ballSpeed = 2000;
    // public float moveSpeed = 5;

    // public Transform BallSpawn;

    void Update()
    {
        // Vector3 move = Vector3.zero;
        // move.z = Input.GetAxis("Horizontal");

        // transform.position += move * moveSpeed * Time.deltaTime;
    }

    public void Shoot() {
        GetComponent<Rigidbody>().AddForce(ballSpeed * transform.forward, ForceMode.Impulse);
    }

    // public void Reset(object _ball)
    // {
    //     gameObject.transform.position = BallSpawn.position;
    //     gameObject.transform.rotation = BallSpawn.rotation;
    //     gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    //     gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    // }

}
