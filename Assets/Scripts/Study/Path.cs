using System;
using DG.Tweening;
using UnityEngine;

public class Path : MonoBehaviour
{

    [SerializeField] private Vector3[] _wayPoints;

    private void Start()
    {
        Tween tween = transform.DOPath(_wayPoints, 5f, PathType.CatmullRom)
            .SetOptions(true)
            .SetLookAt(0.01f)
            .SetLoops(5)
            .SetEase(Ease.Linear);
    }
}