using UnityEngine;

public class ModelGarbage : MonoBehaviour
{
    // Dibuja un Gizmo en la vista del editor
    void OnDrawGizmos()
    {
        // Cambiar el color del Gizmo
        Gizmos.color = Color.red;

        // Ajustar el tamaño del Gizmo basado en la escala del objeto
        Vector3 scale = transform.lossyScale;
        float maxScale = Mathf.Max(scale.x, scale.y, scale.z); // Elegir el mayor eje para representar uniformidad

        // Dibujar una esfera con el tamaño basado en la escala
        Gizmos.DrawSphere(transform.position, 0.5f * maxScale);
    }
}


