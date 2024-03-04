using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxisRotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        float currentYRotation = transform.rotation.eulerAngles.y;        
        currentYRotation += _speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.rotation.x, currentYRotation, transform.rotation.z);
    }
}
