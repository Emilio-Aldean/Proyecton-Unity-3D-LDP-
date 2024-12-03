using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Target;
    public float smoothSpeed = 5f;  // Añadido: velocidad de suavizado configurable
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        if (Target == null)
        {
            Debug.LogError("No se ha asignado un objetivo a la cámara!");
            return;
        }
        offset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Target == null) return;  // Verificación adicional de seguridad

        Vector3 desiredPosition = Target.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);
    }
}
