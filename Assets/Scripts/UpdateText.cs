using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    public Text Choco; // 1.5w
    public Text Red; // 0.59h
    public Text Cyan; // 0.7h
    public Text Green; // 0.53h
    public Text Purple; // 0.3h
    public Text Yellow; // 0.46h
    public Text Blue; // 1h
    public Text Pink; // 0.53h
    public Text Brown1; // 0.7w
    public Text Brown2; // 0.83w
    public Text Brown3; // 1.3w
    public Text Brown4; // 0.61w
    public Text Brown5; // 0.44w
    public Text Brown6; // 0.23w
    
    public Text Height;
    public Text Weight;

    public void UpdateTexts()
    {
        var h = float.Parse(Height.text);
        var w = float.Parse(Weight.text);
        Choco.text = (w * 1.5f).ToString();
        Red.text = (h * 0.59f).ToString();
        Cyan.text = (h * 0.7).ToString();
        Green.text = (h * 0.53).ToString();
        Purple.text = (h * 0.3).ToString();
        Yellow.text = (h * 0.46).ToString();
        Blue.text = (h * 1).ToString();
        Pink.text = (h * 0.53).ToString();
        Brown1.text = (w * 0.7).ToString();
        Brown2.text = (w * 0.83).ToString();
        Brown3.text = (w * 1.3).ToString();
        Brown4.text = (w * 0.61).ToString();
        Brown5.text = (w * 0.44).ToString();
        Brown6.text = (w * 0.23).ToString();
    }
}
