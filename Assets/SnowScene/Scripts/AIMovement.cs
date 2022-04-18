using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float rotationSpeed = 100f;
    public float fallFrequency = 1000f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private readonly bool isRotatingRight = false;
    private bool isWalking = false;
    private float countFallInterval = 0;

    Rigidbody rb;
    Animation animate;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animate = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        ++countFallInterval;
        if(isWandering == false)
        {
            
            StartCoroutine(Wander());
        }
        if(isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);
        }
        if(isWalking == true)
        {
            rb.AddForce(-transform.right * movementSpeed);
        }
        if(countFallInterval == fallFrequency)
        {
            animate.Play("run");
            countFallInterval = 0;
        }
    }

    IEnumerator Wander()
    {
        animate.Play("walk");
        int rotationTime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 3);
        int rotateDirection = Random.Range(1, 2);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 3);

        isWandering = true;
        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);

        if(rotateDirection == 1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }

        if (rotateDirection == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }

        isWandering = false;
    }
}
