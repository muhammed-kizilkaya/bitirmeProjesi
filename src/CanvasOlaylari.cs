using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasOlaylari : MonoBehaviour
{

public float rotationMin = 0f;
public float rotationMax = 0f;
public Slider RotateSlider;
public Slider ScaleSlider;

public Slider donder;

[SerializeField] float currentRotation = 0f;
[SerializeField] float currentScale = 0f;
     // Use this for initialization


     // Start is called before the first frame update
void Start()
{
RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();

donder = GameObject.Find("donder").GetComponent<Slider>();
}

     // Update is called once per frame
void Update()
{
transform.localEulerAngles = new Vector3(0, RotateSlider.value, 0);

transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
}
private void OnGUI()
{
currentRotation = GUI.HorizontalSlider(new Rect(0, 0, 0, 0), currentRotation, 0.0f,0f);
    transform.localEulerAngles = new Vector3(0, 0, currentRotation);
    currentRotation = GUI.HorizontalSlider(new Rect(0, 0,0,0), currentScale, 0.0f, 0f);
    transform.localScale = new Vector3(currentScale, currentScale, currentScale);
}
public void AdjustAngle(float newAngle)
{ }
public void AdjustScale(float newscale)
{ }



}