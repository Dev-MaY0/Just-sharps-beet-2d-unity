using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private AudioSource _audioSource;

    public Slider slider;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
        slider.maxValue = _audioSource.clip.length;
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_audioSource.time);
        if (!_audioSource.isPlaying)
        {
            Debug.Log("ÉQÅ[ÉÄèIóπ");
        }
        else
        {
            slider.value = _audioSource.time;
        }
    }
}
