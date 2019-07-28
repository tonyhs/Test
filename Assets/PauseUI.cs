using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour
{

    public GameObject audio;
    public GameObject onbtn;
    public GameObject offbtn;
    public GameObject uipause;

    // Start is called before the first frame update

    public void on() 
    {
        audio.SetActive(true);
        offbtn.SetActive(false);
        onbtn.SetActive(true);
    }
    public void off()
    {
        audio.SetActive(false);
        offbtn.SetActive(true);
        onbtn.SetActive(false);
    }
    public void Hide()
    {
        uipause.SetActive(false);
    }
    public void show()
    {
        uipause.SetActive(true);
    }
}
