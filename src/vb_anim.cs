using UnityEngine;
using UnityEngine.Events;
using Vuforia;

 // unity de modelin AR biçiminde, sanal buton ve animasyon şeklinde gözükmesi için gerekli unity kodları
public class vb_anim : MonoBehaviour
{
 
    public GameObject vbBtnObj;
    public Animator cubeAni;
 
    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("LacieBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
 
        cubeAni.GetComponent<Animator>();
    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("model_animation");
        Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Button released");
    }
}