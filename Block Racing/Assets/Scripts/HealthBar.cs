using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Slider that show the Health
    public Slider slider;

    /// <summary>
    /// Set max. Health of a Object
    /// </summary> 
    public void SetMaxHealth(int health){
        slider.maxValue = health;
        slider.value = health;
    }

    /// <summary>
    /// Set new Health of a Object
    /// </summary> 
    public void SetHealth(int health){
        slider.value = health;
    }
}
