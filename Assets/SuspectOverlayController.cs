using UnityEngine;

public class SuspectOverlayController : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject suspectOverlay;   // assigne ici le panel SuspectOverlay

    private bool isOpen = false;

    void Update()
    {
        // Fermer l’overlay avec la touche Échap
        if (isOpen && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseOverlay();
        }
    }

    // Appelée par le bouton loupe
    public void OpenOverlay()
    {
        if (suspectOverlay != null)
        {
            suspectOverlay.SetActive(true);
            isOpen = true;
        }
    }

    // Appelée par le bouton X ou par Escape
    public void CloseOverlay()
    {
        if (suspectOverlay != null)
        {
            suspectOverlay.SetActive(false);
            isOpen = false;
        }
    }
}
