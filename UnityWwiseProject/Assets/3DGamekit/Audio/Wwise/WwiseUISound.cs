using UnityEngine;

namespace Gamekit3D
{
    public class WwiseUISound : MonoBehaviour
    {
        void Start()
        {
            var result = AkUnitySoundEngine.LoadBank("Main",  out uint bankID);
            Debug.Log("Bank load result: " + result);
        }

        public void PlayHover()
        {
            uint result = AkUnitySoundEngine.PostEvent("U_Hover", gameObject);
        }

        public void PlaySelect()
        {
            AkUnitySoundEngine.PostEvent("U_Select", gameObject);
        }

        public void PlayBack()
        {
            AkUnitySoundEngine.PostEvent("U_Back", gameObject);
        }

        public void PlayQuit()
        {
            AkUnitySoundEngine.PostEvent("U_Quit", gameObject);
        }
    }
}