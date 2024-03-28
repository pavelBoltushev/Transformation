using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ImageColorChanger : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;    

    private void Start()
    {
        _image.DOColor(_color, _duration).SetLoops(_repeats, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
