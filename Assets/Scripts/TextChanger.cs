using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;

    private void Start()
    {
        Sequence sequnce = DOTween.Sequence();

        sequnce.Append(_text.DOText("������ �����", _duration).SetEase(Ease.Linear));
        sequnce.Append(_text.DOText("����������", _duration).SetRelative().SetEase(Ease.Linear));
        sequnce.Append(_text.DOText("������� ������", _duration, true, ScrambleMode.All).SetEase(Ease.Linear));
        sequnce.SetLoops(_repeats, LoopType.Restart);
    }
}
