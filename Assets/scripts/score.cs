using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public Text finalscoretext;
    void Update()
    {
        float small =  46.77f;
        scoretext.text = (player.position.z+small).ToString("0");
    }
}