using UnityEngine;
using UnityEngine.SceneManagement;

public class SuspectResolver : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject suspectOverlay;
    // win/lose are scenes now — set these names in the Inspector
    public string winSceneName = "Win";
    public string loseSceneName = "Lose";

    [Header("Correct Suspect")]
    public string correctSuspect = "Henry";  // <-- Le coupable est Henry Collins

    public void SelectSuspect(string suspectName)
    {
        if (suspectOverlay) suspectOverlay.SetActive(false);

        if (suspectName == correctSuspect)
        {
            if (!string.IsNullOrEmpty(winSceneName)) SceneManager.LoadScene(winSceneName);
            else Debug.LogWarning("winSceneName not set on SuspectResolver");
        }
        else
        {
            if (!string.IsNullOrEmpty(loseSceneName)) SceneManager.LoadScene(loseSceneName);
            else Debug.LogWarning("loseSceneName not set on SuspectResolver");
        }
    }

    // Hook this to the 3 wrong buttons (no parameter)
    public void SelectWrongSuspect()
    {
        if (suspectOverlay) suspectOverlay.SetActive(false);
        if (!string.IsNullOrEmpty(loseSceneName)) SceneManager.LoadScene(loseSceneName);
        else Debug.LogWarning("loseSceneName not set on SuspectResolver");
    }
}
