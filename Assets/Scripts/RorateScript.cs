using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RorateScript : MonoBehaviour
{
    public float rotateSpeed = 10;
    public float minMaxRotationAngles = 20;
    protected bool turnRight = true;
    protected float min = 0;
    // Start is called before the first frame update
    void Start()
    {
        min = 360 - minMaxRotationAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (turnRight)
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
            if (transform.rotation.eulerAngles.y > minMaxRotationAngles && transform.rotation.eulerAngles.y < min)
            {
                turnRight = false;
            }
        }
        else
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
            if (transform.rotation.eulerAngles.y > minMaxRotationAngles && transform.rotation.eulerAngles.y < min)
            {
                turnRight = true;
            }
        }
    }
}
