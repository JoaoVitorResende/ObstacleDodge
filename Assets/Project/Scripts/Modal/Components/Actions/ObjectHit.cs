using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            ObjectHitAction();
    }
    private void ObjectHitAction()
    {
        GameManager.instance.SetValueToScore();
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public static void DestroyedObject(GameObject objectToDestroy) 
    {
        Destroy(objectToDestroy);
        TriggerProjectile.SetIsOnAreaTrigger(false);
        GameManager.instance.SpawnProjectiles();
    }
}
