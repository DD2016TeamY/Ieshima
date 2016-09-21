using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using STATIC_SPACE;

public class DrawNations : MonoBehaviour {
    public Text TextBox;

	// Use this for initialization
	void Start () {
        TextBox = this.GetComponent<Text>();
        TextBox.text = STATIC_SPACE.StaticValue.Population.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
        TextBox.text = STATIC_SPACE.StaticValue.Population.ToString();
    }
}
