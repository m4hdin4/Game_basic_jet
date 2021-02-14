using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{

    [SerializeField] Vector3 movementVector;
    [SerializeField] float speed = 2f;
    [Range(0, 1)] [SerializeField] float movementFactor;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(speed <= Mathf.Epsilon)
        {
            return;
        }
        float rotate = (Time.time / speed) * 6.28f;
        movementFactor = Mathf.Sin(rotate) / 2 + 0.5f;
        transform.position = startPos + (movementFactor * movementVector);
    }
}
