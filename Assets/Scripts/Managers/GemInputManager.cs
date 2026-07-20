using UnityEngine;
using UnityEngine.InputSystem;

public class GemInputManager : MonoBehaviour
{
    private Camera mainCamera;

    void Awake()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Mouse.current == null)
            return;

        if (!Mouse.current.leftButton.wasPressedThisFrame)
            return;

        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Ray ray = mainCamera.ScreenPointToRay(mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Gem gem = hit.collider.GetComponent<Gem>();

            if (gem != null)
            {
                gem.Select();
            }
        }
    }
}
