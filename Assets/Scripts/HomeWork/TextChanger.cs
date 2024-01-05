using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    {
        _text1.DOText("замена текста", 3f).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
        _text2.DOText(" дополнение текста", 3f).SetRelative().SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
        _text3.DOText("замена с перебором", 3f, true, ScrambleMode.All)
            .SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
        _text3.DOColor(Color.green, 3f);
    }
}