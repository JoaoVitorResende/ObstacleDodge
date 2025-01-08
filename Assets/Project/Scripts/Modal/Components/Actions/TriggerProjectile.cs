using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    private static bool isOnArea = false;
    private static Vector3 playerLastPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SetPlayerPosition(other.gameObject.transform.position);
            SetIsOnAreaTrigger(true);
        }
    }
    private void SetPlayerPosition(Vector3 playerPosition) => playerLastPosition = playerPosition;
    public static Vector3 GetPlayerPosition() => playerLastPosition;
    public static void SetIsOnAreaTrigger(bool value) => isOnArea = value;
    public static bool GetIsOnAreaTrigger() => isOnArea;
}
