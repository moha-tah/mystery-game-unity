using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject instructionsOverlay; // assigne dans l’inspector

    public void PlayGame()
    {
        SceneManager.LoadScene(1); // change par ta scène
    }

    public void ShowInstructions()
    {
        instructionsOverlay.SetActive(true);
    }

    public void HideInstructions()
    {
        instructionsOverlay.SetActive(false);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    void Update()
    {
        if (instructionsOverlay.activeSelf && Input.GetKeyDown(KeyCode.Escape))
            HideInstructions();
    }

}
