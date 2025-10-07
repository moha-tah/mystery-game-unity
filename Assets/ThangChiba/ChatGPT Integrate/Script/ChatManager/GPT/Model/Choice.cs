using System;

namespace ThangChibaGPT

{
    [Serializable]
    public class Choice
    {
        public Delta delta;
        public int index;
        public string finish_reason;
    }
}