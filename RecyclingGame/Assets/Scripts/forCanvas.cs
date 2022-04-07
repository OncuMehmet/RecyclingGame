using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forCanvas : MonoBehaviour
{
    public Text SkorText;
    public Text finishLog;
    Offset offsetstop;
    

    private void Start()
    {
        finishLog.gameObject.SetActive(false);
        Invoke(nameof(finishlogActive), 47.5f);
    }
    private void Update()
    {
        SkorText.text = "Skor: "+Skor.skorToplam.ToString();
    }
    public void finishlogActive()
    {
        finishLog.gameObject.SetActive(true);

    }
}