using UnityEngine;

public class Animaciones: MonoBehaviour
{

    [SerializeField] private GameObject Indicaciones;

    void Start()
    {
        //Mueve con un énfasis rebotón las indicaciones hacia adentro.
        LeanTween.moveX(Indicaciones.GetComponent<RectTransform>(), 133, 1.5f).setDelay(2.5f)
        .setEase(LeanTweenType.easeOutBounce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
