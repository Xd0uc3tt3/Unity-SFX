using UnityEngine;

public class BranchSnap : MonoBehaviour
{
    public AudioSource sfxSourceBranch;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sfxSource.Play();
        }
    }
}
