using UnityEngine;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        string objectName = other.gameObject.name;

        // Intentar destruir el objeto
        Destroy(other.gameObject);

        // Mensaje de depuración después de solicitar la destrucción
        Debug.Log($"Se programó la destrucción del objeto: {objectName}");
    }
}
