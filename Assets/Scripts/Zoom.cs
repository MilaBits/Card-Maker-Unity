using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour {

    private float ZoomLevel;
    
    public void ChangeZoom(float value) {
        transform.localScale = new Vector3(value, value, value);
    }
}
