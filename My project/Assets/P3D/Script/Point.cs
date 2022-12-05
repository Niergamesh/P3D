
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    private int Score = 0;
    private TMP_Text t;
    private void Start()
    {
        t = GetComponent<TMP_Text>();    
    }
    public void UpdateText()
    {
        Score++;
        t.text ="Score: "+ Score.ToString();
    }
}
