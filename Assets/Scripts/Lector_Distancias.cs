using UnityEngine;

public class Lector_Distancias : MonoBehaviour
{

    private Animator animator;
    private Transform chest;
    private Transform leftThigh;

    void Start()
    {
        animator = GetComponent<Animator>();

        chest = animator.GetBoneTransform(HumanBodyBones.Chest);
        leftThigh = animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg);

        if (chest == null || leftThigh == null)
        {
            Debug.LogError("No se encontraron los huesos necesarios");
        }
    }

    void Update()
    {
        if (chest == null || leftThigh == null) return;

        float distance = Vector3.Distance(chest.position, leftThigh.position);
        Debug.Log($"Distancia muslo-pecho: {distance:F3}");
    }
}

