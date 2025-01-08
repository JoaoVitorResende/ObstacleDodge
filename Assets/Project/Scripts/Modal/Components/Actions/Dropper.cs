using UnityEngine;

public class Dropper : MonoBehaviour
{
    private void Update() => CheckTimer();
    private void CheckTimer()
    {
        if (Time.time >= Values.TimeToFall && GetComponent<Rigidbody>().isKinematic)
        {
            MakeObjectFall();
            MakeObjectVisible();
        }
    }
    private void MakeObjectVisible() => GetComponent<MeshRenderer>().enabled = true;
    private void MakeObjectFall() => GetComponent<Rigidbody>().isKinematic = false;
}
