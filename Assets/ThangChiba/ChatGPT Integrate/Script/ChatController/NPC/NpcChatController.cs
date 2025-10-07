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
    }
}