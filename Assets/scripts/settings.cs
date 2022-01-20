using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    public void tilt()
    {
        PlayerPrefs.SetInt("tilt", 1);
        SceneManager.LoadScene("Start");
    }
    public void tap()
    {
        PlayerPrefs.SetInt("tilt", 0);
        SceneManager.LoadScene("Start");
    }
}
