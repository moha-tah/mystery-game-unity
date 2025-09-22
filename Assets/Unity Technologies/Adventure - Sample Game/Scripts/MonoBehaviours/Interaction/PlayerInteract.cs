using UnityEngine;
using TMPro;   // if you’re using TextMeshPro InputField

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 2f;
    public TMP_InputField npcInputField;   // assign in Inspector
    private NPCInteractable currentNPC;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out NPCInteractable npcInteractable))
                {
                    currentNPC = npcInteractable;
                    npcInteractable.Interact(); // still prints "interact"
                    ShowInputField(true);
                    return; // stop after first NPC
                }
            }
        }

        // Auto-hide input if you walk away
        if (currentNPC != null)
        {
            float distance = Vector3.Distance(transform.position, currentNPC.transform.position);
            if (distance > interactRange)
            {
                currentNPC = null;
                ShowInputField(false);
            }
        }
    }

    private void ShowInputField(bool show)
    {
        npcInputField.gameObject.SetActive(show);

        if (show)
        {
            npcInputField.text = "";
            npcInputField.ActivateInputField();
        }
    }
}
