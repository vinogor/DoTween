using System;
using DG.Tweening;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _lastTargetPosition;
    private Tweener _tween;

    private void Start()
    {
        _tween = transform.DOMove(_target.position, 2f).SetAutoKill(false);
        _lastTargetPosition = _target.position;
    }

    private void Update()
    {
        if (_lastTargetPosition != _target.position)
        {
            _tween.ChangeEndValue(_target.position, true).Restart();
            _lastTargetPosition = _target.position;
        }
    }
}