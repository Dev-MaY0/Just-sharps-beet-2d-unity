using UnityEngine;


public class GameManager : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
    }


    // Update is called once per frame
    void Update()
    {
        if (!_audioSource.isPlaying)
        {
            Debug.Log("ÉQÅ[ÉÄèIóπ");
        }
    }
}
