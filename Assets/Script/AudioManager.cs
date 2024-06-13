using UnityEngine;

public class AudioManage : MonoBehaviour
{
    [Header ("------ Audio Source ------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header ("------ Audio Source ------")]
    public AudioClip background;
    public AudioClip death;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
