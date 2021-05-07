using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class confOpcion : MonoBehaviour
{
    public new AudioMixer audio;
    public void Volumen(float volumen)
    {
        audio.SetFloat("volume", volumen);
    }
}
