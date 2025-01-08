using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject spawn;
    public static GameManager instance;
    private int score = Values.NeutralIntValue;
    private void Start() => instance = this;
    public void SetValueToScore() => score++;
    public int GetScore() => score;
    public void SpawnProjectiles() => Instantiate(projectile, spawn.transform.position, spawn.transform.rotation);
}
