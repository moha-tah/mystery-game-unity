using UnityEngine;

namespace ThangChibaGPT

{
    public class NpcChatController : AIChatController
    {
        private BarkController barkController;

        private void Awake()
        {
            barkController = GetComponentInChildren<BarkController>();
        }

        public override void OnReceiveChunkResponse(string content)
        {
            barkController.SetBark(content);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Debug.Log("OnTriggerEnter: " + other.name + " with tag " + other.tag);
            }
        }
    }
}