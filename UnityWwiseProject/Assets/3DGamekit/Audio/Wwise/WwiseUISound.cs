using UnityEngine;

namespace Gamekit3D
{
    public class WwiseUISound : MonoBehaviour
    {
        void Start()
        {
            // JÚLIA: Implemented debug an see issues with banks and sounds not reproducing
            //var result = AkUnitySoundEngine.LoadBank("Main",  out uint bankID);
            //Debug.Log("Bank load result: " + result);
        }

        public void PlayHover()
        {
            AkUnitySoundEngine.PostEvent("U_Hover", gameObject);

            //Debug.Log("Hover event triggered");
            //uint result = AkUnitySoundEngine.PostEvent("U_Hover", gameObject);
            //Debug.Log($"PostEvent returned ID: {result}");
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