using UnityEngine;

namespace ThangChibaGPT

{
    public abstract class ChatModeState : MonoBehaviour
    {
        public abstract void OnSetup();

        public abstract void OnUninstall();

        public abstract void SubmitChat(string content);
    }
}