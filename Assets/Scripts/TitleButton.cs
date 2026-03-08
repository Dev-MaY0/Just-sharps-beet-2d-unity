using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject panel;
    public GameObject configPanel;

    private void Start()
    {
        panel.SetActive(true);
        configPanel.SetActive(false);
    }
    public void StartBtn()
    {
        SceneManager.LoadScene("game");
    }

    public void ShowConfigPanel()
    {
        panel.SetActive(false);
        configPanel.SetActive(true);
    }    

    public void ShowPane()
    {
        panel.SetActive(true);
        configPanel.SetActive(false);
    }

}
