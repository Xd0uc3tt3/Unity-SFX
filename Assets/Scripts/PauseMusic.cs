using UnityEngine;

public class PauseMusic : MonoBehaviour
{
    public AudioSource musicSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (musicSource.isPlaying)
                musicSource.Pause();
            else
                musicSource.UnPause();
        }
    }
}
