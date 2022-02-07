using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class thre : MonoBehaviour
{

    private Text Mytext = null;

    private Button Mybutton = null;

    // Start is called before the first frame update
    void Start()
    {
        var prefabtext = Resources.Load("Main/prefabs/Text");

        GameObject Text_object = (GameObject)Instantiate(prefabtext, new Vector3(0, 0, 0), Quaternion.identity);

        Mytext = Text_object.GetComponent<Text>();

        Mytext.transform.SetParent(this.gameObject.GetComponent<RectTransform>());

        Mytext.text = "Hello World!";

        RectTransform Rect_text = Text_object.GetComponent<RectTransform>();

        Mytext.transform.Translate((Screen.width * 1.0f), (Screen.height * 1.0f) - Rect_text.rect.height * 0.5f, 0);

        var prefabbutton = Resources.Load("Main/prefabs/Button");

        GameObject Button_object = (GameObject)Instantiate(prefabbutton, new Vector3(0, 0, 0), Quaternion.identity);

        Mybutton = Button_object.GetComponent<Button>();

        Mybutton.transform.SetParent(this.gameObject.GetComponent<RectTransform>());

        Mybutton.onClick.AddListener(btn_click);

        RectTransform Rect_button = Button_object.GetComponent<RectTransform>();

        Mybutton.transform.Translate((Screen.width * 0.5f), (Screen.height * 0.5f) - Rect_button.rect.height * 0.5f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_click()
    {
        Text btntext = Mybutton.GetComponentInChildren<Text>();

        btntext.text = "Changed Text";
    }

}
