using UnityEngine;
using DG.Tweening;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;    
        
    private void Update()
    {
        transform.DOScale(_scale, _duration).SetLoops(_repeats, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
