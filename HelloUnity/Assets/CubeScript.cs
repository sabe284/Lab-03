using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float RotateSpeed = 1.0f;
    public Vector3 SpinSpeed = new Vector3(0, 0, 0);
    public Vector3 SpinAxis = new Vector3(0, 1, 0);

    void Start()
    {
        SpinSpeed = new Vector3(Random.value, Random.value, Random.value);
        SpinAxis = Vector3.up;
        SpinAxis.x = (Random.value - Random.value) * .1f;
    }

    public void SetSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(SpinSpeed);
        this.transform.RotateAround(Vector3.zero, SpinAxis, RotateSpeed);
    }
}
