using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EeldogBehaviour : MonoBehaviour
{
    public void PlaySound()
    {
        AkUnitySoundEngine.PostEvent("EN_E_Splash", gameObject);
    }
}
