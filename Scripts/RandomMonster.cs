using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomMonster : MonoBehaviour
{
    public GameObject monsterPrefab;
    public int maxMonsterCount = 10;
    public float spawnInterval = 5f;

    private int currentMonsterCount = 0;

    void Start()
    {
        StartCoroutine(SpawnMonstersWithDelay());
    }

    IEnumerator SpawnMonstersWithDelay()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < maxMonsterCount; i++)
        {
            Vector2 spawnPosition = new Vector2(8, Random.Range(1, 5));
            GameObject monster = Instantiate(monsterPrefab, spawnPosition, Quaternion.identity);
            monster.tag = "Zombie";
            monster.AddComponent<MonsterController>();
            currentMonsterCount++;
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Update()
    {
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Zombie");
        if (currentMonsterCount == maxMonsterCount && monsters.Length == 0)
        {
            SceneManager.LoadScene("WinScene");
        }
          
        
    }
}
