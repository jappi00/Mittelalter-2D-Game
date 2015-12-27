using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicManager : MonoBehaviour {

    //Referenzen
    public Slider slider;//Musik Slider
    public Toggle toggle;
    public int setToValue;

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
        Debug.Log(slider.value);
    }
   
    public void SliderInput(float Value)
    {
        Debug.Log(Value);
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
