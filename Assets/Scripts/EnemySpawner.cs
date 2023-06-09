using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab da nave inimiga
    public Vector3 spawnPosition; // Posição de renascimento da nave inimiga

    public GameObject enemyPrefabAnother;
    public Vector3 spawnPositionAnother;

    private GameObject enemyObject; // Referência para o objeto da nave inimiga
    private GameObject enemyObjectAnother;
    private float spawnDelay = 1f; // Tempo de espera em segundos

    private float timer; // Temporizador para controlar o intervalo

    // Update is called once per frame
    void Update()
    {
        // Verifica se o objeto com a tag Enemy ainda existe na cena
        enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        enemyObjectAnother = GameObject.FindGameObjectWithTag("Enemy2");

        // Se não existir, inicia a contagem do tempo
        if (enemyObject == null)
        {
            timer += Time.deltaTime;

            // Se o intervalo de tempo for maior ou igual ao tempo de espera
            if (timer >= spawnDelay)
            {
                SpawnEnemy();
                timer = 0f; // Reinicia o temporizador
            }
        }

        if (enemyObjectAnother == null)
        {
            timer += Time.deltaTime;

            // Se o intervalo de tempo for maior ou igual ao tempo de espera
            if (timer >= spawnDelay)
            {
                SpawnEnemyAnother();
                timer = 0f; // Reinicia o temporizador
            }
        }
    }

    // Função para spawnar um novo objeto inimigo
    public void SpawnEnemy()
    {
        enemyObject = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        enemyObject.tag = "Enemy"; // Define a tag do novo objeto como Enemy
        GameObject.FindGameObjectWithTag("ScoreTracker").GetComponent<ScoreTracker>().EnemyDestroyed();
    }

    public void SpawnEnemyAnother()
    {
        enemyObject = Instantiate(enemyPrefabAnother, spawnPositionAnother, Quaternion.identity);
        enemyObject.tag = "Enemy2"; // Define a tag do novo objeto como Enemy
        GameObject.FindGameObjectWithTag("ScoreTracker").GetComponent<ScoreTracker>().EnemyDestroyed();
    }
}
