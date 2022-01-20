using UnityEngine;
using UnityEngine.SceneManagement;
public class closewindow : MonoBehaviour
{
    public void CloseRulesWindow()
    {
        SceneManager.LoadScene("Start");
    }
}
