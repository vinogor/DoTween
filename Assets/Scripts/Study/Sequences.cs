using DG.Tweening;
using UnityEngine;

public class Sequences : MonoBehaviour
{
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveY(3f, 4f).SetRelative());

        // вставляем внутрь одну анимацию в другую
        sequence.Insert(0f, transform.DORotate(new Vector3(60f, 15f, 0f), 2f));

        
        sequence.Append(transform.DOMoveY(3f, 4f).SetRelative());
        sequence.Insert(4f, transform.DORotate(new Vector3(0f, 40f, 15f), 2f));

        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}