using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacles : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 100f;
    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}
