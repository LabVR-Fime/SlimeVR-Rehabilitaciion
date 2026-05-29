using UnityEngine;
using TMPro;

public class UI_Creditos : MonoBehaviour
{

    public TMP_Text Creditos;       //Nombres de créditos

    void Start()
    {
        RectTransform rt = Creditos.GetComponent<RectTransform>();      //Declaramos la variable de cr�ditos.
        float InicioY = rt.anchoredPosition.y;                          //Declaramos la posici�n inicial

        LeanTween.moveY(rt, InicioY + 80000, 1070)           //Mover algo 80000 unidades hacia arriba a 1070uph
            .setEaseLinear();                                //De manera lineal
            }

    void Update()
    {
        
    }
}
