using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class start : MonoBehaviour
{
    public GameObject panel;
    public Button startbut;
    public Button rulebut;
    // Start is called before the first frame update
    private void Start()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            //codes for portrait
            panel.SetActive(true);
            startbut.enabled = false;
            rulebut.enabled = false;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Rules()
    {
        SceneManager.LoadScene("Rules");
    }
    public void closeDialog()
    {
        panel.SetActive(false);
        startbut.enabled = true;
        rulebut.enabled = true;
    }
   
}
