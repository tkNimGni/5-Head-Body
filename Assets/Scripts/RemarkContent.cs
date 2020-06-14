using UnityEngine;
using UnityEngine.UI;

public class RemarkContent : MonoBehaviour
{
    void Start()
    {
        System.String key = "key";
        InputField content = gameObject.GetComponent<InputField>();
        content.onEndEdit.AddListener(delegate { PlayerPrefs.SetString(key, content.textComponent.text); });
        if (PlayerPrefs.HasKey(key)) content.text = PlayerPrefs.GetString(key);
    }
}
