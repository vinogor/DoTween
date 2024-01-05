using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private void Start()
    {
        _spriteRenderer.DOFade(_color.a, _duration);
        _spriteRenderer.DOColor(_color, _duration);
    }
}