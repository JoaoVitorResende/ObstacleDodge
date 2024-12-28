using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField] private InputSystem_Actions inputActions;
    public static InputManager Instance;
    public InputAction move;
    private Vector2 movementValues;
    private void Awake()
    {
        inputActions = new();
    }
    private void OnEnable()
    {
        move = inputActions.Player.Move;
        inputActions.Enable();
    }
    private void OnDisable()
    {
        move = inputActions.Player.Move;
        inputActions.Disable();
    }
    private void Update()
    {
        CallMovementInput();
    }
    private void CallMovementInput()
    {
        PlayerMover.instance.PlayerMovement(move.ReadValue<Vector2>());
    }
    public Vector2 GetMoveValues() => movementValues;
    public InputManager() => Instance = this;
}
