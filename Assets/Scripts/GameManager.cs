using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class GameManager : MonoBehaviour
{
    private AudioSource _audioSource;

    public Slider slider;
    public GameObject cliearText;

    private bool _isGameCliear = false;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
        slider.maxValue = _audioSource.clip.length;
        cliearText.SetActive(false);
        _isGameCliear = false ;
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_audioSource.time);
        if (!_audioSource.isPlaying && !_isGameCliear)
        {
            _isGameCliear = true;
            StartCoroutine(GameCliear());
        }
        else
        {
            slider.value = _audioSource.time;
        }
    }

    private IEnumerator GameCliear()
    {
        cliearText.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("main");
        yield break;
    }
}
