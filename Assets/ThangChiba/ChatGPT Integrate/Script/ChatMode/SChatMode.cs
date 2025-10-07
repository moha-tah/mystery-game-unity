using System;

namespace ThangChibaGPT

{
    [Serializable]
    public struct SChatMode
    {
        public EChatMode eChatMode;
        public ChatModeState chatState;
    }
}