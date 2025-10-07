using System;

namespace ThangChibaGPT

{
    public enum Role
    {
        system,
        user,
        assistant
    }

    [Serializable]
    public class AIMessage
    {
        public string role;
        public string content;

        public AIMessage(Role role, string content)
        {
            this.role = role.ToString();
            this.content = content;
        }
    }
}