using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComidaManager : MonoBehaviour
{
    [SerializeField] public GameObject lechePrefab;
    [SerializeField] public GameObject choclotePrefab;
    [SerializeField] public GameObject ajoPrefab; // Nuevo
    [SerializeField] public GameObject cafePrefab; // Nuevo
    public float maxX;
    [SerializeField] public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;
    [SerializeField] public GameObject tapText;
    public TextMeshProUGUI scoreText;
    int score = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            tapText.SetActive(false);
        }
    }
    public void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }
    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);


        int randomPrefabIndex = Random.Range(0, 4);
        GameObject prefabToSpawn;


        switch (randomPrefabIndex)
        {
            case 0:
                prefabToSpawn = lechePrefab;
                break;
            case 1:
                prefabToSpawn = choclotePrefab;
                break;
            case 2:
                prefabToSpawn = ajoPrefab;
                break;
            case 3:
                prefabToSpawn = cafePrefab;
                break;
            default:
                prefabToSpawn = lechePrefab;
                break;
        }

        Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }
}
