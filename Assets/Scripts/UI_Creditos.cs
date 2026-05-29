using UnityEngine;
using TMPro;

public class UI_Creditos : MonoBehaviour
{

    public TMP_Text Creditos;

    void Start()
    {
        RectTransform rt = Creditos.GetComponent<RectTransform>();         //Declaramos la variable de cr�ditos.
        float InicioY = rt.anchoredPosition.y;                                  //Declaramos la posici�n inicial

        LeanTween.moveY(rt, InicioY + 3000, 40f)             //Mover algo 3000 unidades hacia arriba a 40uph
            .setEaseLinear();                                //De manera lineal
            }

    void Update()
    {
        
    }
}
