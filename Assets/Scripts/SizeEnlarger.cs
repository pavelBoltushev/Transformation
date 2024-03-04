using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeEnlarger : MonoBehaviour
{
    [SerializeField] private float _sizeChangeSpeed;

    private float _scale = 1;
        
    private void Update()
    {
        _scale += _sizeChangeSpeed * Time.deltaTime;
        transform.localScale = new Vector3(_scale, _scale, _scale);
    }
}
