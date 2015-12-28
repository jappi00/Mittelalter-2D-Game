using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicManager : MonoBehaviour {

    //Referenzen
    public Slider slider;  //Musik Slider
    public Toggle toggle;  //Musik on/of toggle
    public int setToValue; //Bei anmachen der Musik Zielwert

    public void OnOfMusic(bool ToogleInput)
    {
        if (ToogleInput)
        {
            slider.value = setToValue;
        }
        else
        {
            slider.value = 0;
        }
    }
   
    public void SliderInput(float Value)
    {
        if(Value == 0)
        {
            toggle.isOn = false;
        }
        else
        {
            toggle.isOn = true;
        }
    }
}
