using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Repeticiones_UI_Animaciones : MonoBehaviour
{

    [SerializeField] public TMPro.TMP_Text TextoAgitado1;
    [SerializeField] public GameObject GrupoCanvas;


    private void Start()
    {
        AgitarX(TextoAgitado1);
    }


    private void BajarAlpha()
    {
        LeanTween.alpha(GrupoCanvas.GetComponent<RectTransform>(), 0f, 4f).setDelay(8.0f);
        GrupoCanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void AgitarX(TMP_Text TextoAgitado1)
    {
        RectTransform rt = TextoAgitado1.GetComponent<RectTransform>();
        float startX = rt.anchoredPosition.x;
        float offset = 10f;
        LeanTween.moveX(rt, startX + offset, 0.1f)
            .setDelay(2.0f)
            .setEase(LeanTweenType.easeOutQuad)
            .setOnComplete(() =>
            {
                LeanTween.moveX(rt, startX, 0.3f)
                    .setEase(LeanTweenType.easeOutBounce);
            });

    }
}
