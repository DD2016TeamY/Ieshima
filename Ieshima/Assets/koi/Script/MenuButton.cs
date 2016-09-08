using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;


public class MenuButton : FactoryClass {
    public GameObject Child;
    void MenuButtonOpen(){
        Child.SetActive(true);
    }
    void MenuButtonClose(){
    Child.SetActive(false);
    }
}
