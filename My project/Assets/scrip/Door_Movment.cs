using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Movment : MonoBehaviour
{
    public float moveDistance = 2.0f;
    public float moveSpeed = 2.0f;
    private Vector3 startPos;
    private Vector3 endPos;
    private bool movingForward = true;

    void Start()
    {
        startPos = transform.position;
        endPos = startPos + Vector3.up * moveDistance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(MoveCube());
        }
    }

    IEnumerator MoveCube()
    {
        float t = 0;
        Vector3 targetPos = movingForward ? endPos : startPos;

        while (t < 1)
        {
            t += Time.deltaTime * moveSpeed;
            transform.position = Vector3.Lerp(transform.position, targetPos, t);
            yield return null;
        }

        movingForward = !movingForward;
    }
}
