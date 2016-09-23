using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using STATIC_SPACE;

public class DrawNationalTrasure : MonoBehaviour {
    public Text TextBox;

    // Use this for initialization
    void Start()
    {
        TextBox = this.GetComponent<Text>();
        TextBox.text = STATIC_SPACE.StaticValue.NationalTreasury.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        TextBox.text = STATIC_SPACE.StaticValue.NationalTreasury.ToString();

    }
}
