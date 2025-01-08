using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Update() 
    {
        if(TriggerProjectile.GetIsOnAreaTrigger())
            MoveTowardsPlayer();
        if (transform.position == TriggerProjectile.GetPlayerPosition())
            ObjectHit.DestroyedObject(gameObject);
    }
    private void MoveTowardsPlayer() => transform.position = Vector3.MoveTowards(transform.position, TriggerProjectile.GetPlayerPosition(), (Time.deltaTime * Values.speed));
}
