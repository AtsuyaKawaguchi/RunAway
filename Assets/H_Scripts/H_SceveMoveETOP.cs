﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class H_SceveMoveETOP : MonoBehaviour
{
    AudioSource m_audio = default;
    
    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            m_audio.Play();
            Invoke("SceneChange",1f);
        }
    }

    void SceneChange()
    {
        SceneManager.LoadScene(9);
        
    }
}
