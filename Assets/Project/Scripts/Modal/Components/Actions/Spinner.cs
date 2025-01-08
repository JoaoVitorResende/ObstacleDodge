using UnityEngine;

public class Spinner : MonoBehaviour
{
    void Update()
    {
        RotateObject();
    }
    private void RotateObject() => transform.Rotate(Values.NeutralIntValue, Values.spinningNumber, Values.NeutralIntValue);
}
