using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoomer : MonoBehaviour
{
    public void Zoom(Slider slider) {
        transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }
}
