using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float spawnRate = 2.0f;
    public float spawnDistance = 85.0f; // Distancia frente al jugador
    public float spawnHeight = 40.0f;  // Altura donde se generan los obstáculos
    public float obstacleLifetime = 15.0f; // Tiempo límite de existencia de cada obstáculo

    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            // Calcula la posición de generación
            Vector3 spawnPosition = player.position + player.forward * spawnDistance;
            spawnPosition.y += spawnHeight; // Ajusta la altura del obstáculo

            // Selecciona un prefab aleatorio
            int randomIndex = Random.Range(0, obstaclePrefabs.Length);

            // Instancia el obstáculo
            GameObject spawnedObstacle = Instantiate(obstaclePrefabs[randomIndex], spawnPosition, Quaternion.identity);

            // Destruye el obstáculo después de `obstacleLifetime` segundos
            Destroy(spawnedObstacle, obstacleLifetime);

            // Espera antes de generar el siguiente obstáculo
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
