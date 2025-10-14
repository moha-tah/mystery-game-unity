using UnityEngine;

namespace ThangChibaGPT
{
    public class Frame : MonoBehaviour
    {
        [SerializeField] private GameObject messagePrefab;

        public Message AddChatMessage(string content, string role, Sprite avatar)
        {
            var newMessage = Instantiate(messagePrefab, gameObject.transform);

            var message = newMessage.GetComponent<Message>();
            message.SetContent(content);
            message.SetAvatar(avatar);
            return newMessage.GetComponent<Message>();
        }
    }
}