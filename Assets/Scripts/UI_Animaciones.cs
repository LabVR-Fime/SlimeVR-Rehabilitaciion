using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UI_Animaciones : MonoBehaviour
{
    [SerializeField] private GameObject GrupoCanvas;

    [SerializeField] private GameObject ContextoControl_Mouse;
    [SerializeField] private GameObject ContextoControl_Teclado;
    [SerializeField] private GameObject ContextoControl_Cuerpo;

    [SerializeField] public RawImage IMG_SVEI1;
    [SerializeField] public RawImage IMG_SVEI2;
    [SerializeField] public RawImage IMG_SVEI3;

    [SerializeField] public TMPro.TMP_Text TextoMoverX;


    private void Start()
    {



    //Esta variable es s�lo para comprobar que se inicie s�lo una vez el programa
    private static bool AnimacionInicioHecha = false;

    private void Start()
    {
        if (AnimacionInicioHecha) {
            GrupoCanvas.SetActive(false);
            return; }//Si ya se ejecut� entonces ya no lo hace.
        else
        {
            AnimacionInicio();
            AnimacionInicioHecha = true;
            GrupoCanvas.SetActive(true);

        }
    }


    private void AnimacionInicio()
    {
        //Esto mueve los dibujitos al centro pero de manera "rebotona"
        LeanTween.moveX(ContextoControl_Mouse.GetComponent<RectTransform>(), -480, 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveX(ContextoControl_Teclado.GetComponent<RectTransform>(), 20, 1.5f).setDelay(1.8f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveX(ContextoControl_Cuerpo.GetComponent<RectTransform>(), 520, 0.8f).setDelay(2.0f).setEase(LeanTweenType.easeOutBounce);

        //Esto mueve los textos al centro pero de manera "rebotona"
        LeanTween.moveX(IMG_SVEI1.GetComponent<RectTransform>(), 520, 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeOutBounce);   //Cuerpo
        LeanTween.moveX(IMG_SVEI2.GetComponent<RectTransform>(), -480, 1.5f).setDelay(1.8f).setEase(LeanTweenType.easeOutBounce);     //Mouse
        LeanTween.moveX(IMG_SVEI3.GetComponent<RectTransform>(), 20, 0.8f).setDelay(2.0f).setEase(LeanTweenType.easeOutBounce);    //Teclado
        BajarAlpha();
    }


    private void BajarAlpha()
    {
        LeanTween.alpha(GrupoCanvas.GetComponent<RectTransform>(), 0f, 4f).setDelay(8.0f);
        GrupoCanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;


    }

}


