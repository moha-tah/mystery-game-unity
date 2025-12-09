using UnityEngine;
using UnityEngine.SceneManagement;

public class SuspectResolver : MonoBehaviour
{
    [Header("Panels")]
    public GameObject suspectOverlay;
    public GameObject compliceOverlay;

    [Header("Culprits")]
    public string correctMurderer = "Henry";     // Le meurtrier
    public string correctAccomplice = "Marcus";  // Le complice

    [Header("Scene Names")]
    public string winSceneName = "Win";     // Nom exact de ta scène Win
    public string loseSceneName = "Lose";   // Nom exact de ta scène Lose

    // Étape 1 : Choix du meurtrier
    public void SelectSuspect(string suspectName)
    {
        suspectOverlay.SetActive(false);

        if (suspectName == correctMurderer)
        {
            // Meurtrier trouvé → afficher overlay des complices
            compliceOverlay.SetActive(true);
        }
        else
        {
            // Mauvais meurtrier → charger LoseScene
            SceneManager.LoadScene(loseSceneName);
        }
    }

    // Étape 2 : Choix du complice
    public void SelectAccomplice(string compliceName)
    {
        compliceOverlay.SetActive(false);

        if (compliceName == correctAccomplice)
        {
            SceneManager.LoadScene(winSceneName);
        }
        else
        {
            SceneManager.LoadScene(loseSceneName);
        }
    }
}
