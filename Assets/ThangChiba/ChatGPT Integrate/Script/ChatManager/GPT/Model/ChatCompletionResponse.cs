using System;

namespace ThangChibaGPT

{
    [Serializable]
    public class ChatCompletionResponse
    {
        public string id;
        public string @object;
        public long created;
        public string model;
        public Choice[] choices;
    }
}