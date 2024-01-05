using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("замена текста", 3f);
        _text2.DOText("дополнение текста", 3f).SetRelative();
        _text3.DOText("я взломал этот текст", 3f, true, ScrambleMode.All);
        _text3.DOColor(Color.green, 3f);
    }
}