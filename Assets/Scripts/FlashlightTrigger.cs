using UnityEngine;

public class FlashlightTrigger : MonoBehaviour
{
    public Light flashlightLight;
    public AudioSource sfxSourceFlashlight;

    private bool isInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isInside)
        {
            isInside = true;

            flashlightLight.enabled = !flashlightLight.enabled;

            if (sfxSourceFlashlight != null)
                sfxSourceFlashlight.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInside = false;
        }
    }
}