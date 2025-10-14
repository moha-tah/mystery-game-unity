using UnityEngine;
using UnityEngine.UI;

namespace ThangChibaGPT
{
    [RequireComponent(typeof(ScrollRect))]
    public class GUIChatController : AIChatController
    {
        [SerializeField] private ScrollRect scrollRect;
        [SerializeField] private Frame frameChat;
        private Message chunkMessage;

        public override void OnSubmitChat(string content)
        {
            AddMessage(Role.user, content);
            frameChat.AddChatMessage(content, "user");
            chunkMessage = frameChat.AddChatMessage("Réflexion en cours...", "assistant");
        }

        public override void OnReceiveChunkResponse(string content)
        {
            chunkMessage.SetContent(content);
            ScrollToBottom();
        }


        private void ScrollToBottom()
        {
            scrollRect.verticalNormalizedPosition = 0f;
        }
    }
}