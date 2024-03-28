using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;    

    private void Start()
    {
        transform.DORotateQuaternion(Quaternion.Euler(_rotation), _duration).SetLoops(_repeats, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
