using UnityEngine;

namespace ThangChibaGPT
{
    public class CameraFacing : MonoBehaviour
    {
        // Update is called once per frame
        private void LateUpdate()
        {
            transform.forward = Camera.main!.transform.forward;
        }
    }
}