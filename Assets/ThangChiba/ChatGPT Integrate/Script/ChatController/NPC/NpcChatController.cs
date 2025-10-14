using TMPro;
using UnityEngine;

namespace ThangChibaGPT

{
    public class NpcChatController : AIChatController
    {
        private BarkController barkController;
        private ShowHideUI showHideUI;
        private TextMeshProUGUI discussionTitle;

        private void Awake()
        {
            barkController = GetComponentInChildren<BarkController>();
            showHideUI = FindFirstObjectByType<ShowHideUI>();
        }

        public override void OnReceiveChunkResponse(string content)
        {
            barkController.SetBark(content);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                showHideUI.SetActive(true);
                discussionTitle = GameObject.Find("DiscussionTitle").GetComponent<TextMeshProUGUI>();
                discussionTitle.text = "Actuellement avec " + chatStorage.displayName;



                AIState.guiChatController.chatStorage = chatStorage;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                showHideUI.SetActive(false);
            }
        }
    }
}