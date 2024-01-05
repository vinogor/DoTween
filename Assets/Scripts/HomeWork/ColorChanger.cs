using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Color _initialColor;

    private void Start()
    {
        _initialColor = _material.color;
        _material.DOColor(_color, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }

    private void OnDisable()
    {
        _material.color = _initialColor;
    }
}