using UnityEngine;

public class UI_Creditos : MonoBehaviour
{
    void Start()
    {
        RectTransform rt = TextoCreditos.GetComponent<RectTransform>();         //Declaramos la variable de créditos.
        float InicioY = rt.anchoredPosition.y;                                  //Declaramos la posición inicial

        LeanTween.moveY(rt, InicioY + 3000, 40f)             //Mover algo 3000 unidades hacia arriba a 40uph
            .setEaseLinear();                                //De manera lineal
            }

    void Update()
    {
        
    }
}
