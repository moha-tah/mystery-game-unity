using UnityEngine;

public class CompliceOverlayController : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject compliceOverlay;   // Le panel à fermer

    private bool isOpen = false;

    private void OnEnable()
    {
        isOpen = true;
    }

    private void OnDisable()
    {
        isOpen = false;
    }

    void Update()
    {
        if (isOpen && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseOverlay();
        }
    }

    public void CloseOverlay()
    {
        if (compliceOverlay != null)
        {
            compliceOverlay.SetActive(false);
        }
        else
        {
            Debug.LogWarning("CompliceOverlay is missing!");
        }
    }
}
