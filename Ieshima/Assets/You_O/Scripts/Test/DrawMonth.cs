using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using STATIC_SPACE;

public class DrawMonth : MonoBehaviour {
    public Text TextBox;

    // Use this for initialization
    void Start()
    {
        TextBox = this.GetComponent<Text>();
        TextBox.text = STATIC_SPACE.StaticValue.Month.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        TextBox.text = STATIC_SPACE.StaticValue.Month.ToString();
    }
}
