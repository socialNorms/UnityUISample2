using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test007Dlg : MonoBehaviour
{
    public Button m_btnStart;
    public Button m_btnStop;
    public Scrollbar m_bar;
    public Text m_txtResult;
    float m_CurTime;
    float m_CoolTime;
    bool m_isPlaying;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        if (m_isPlaying)
        {
            if (m_bar.value >= 1.0f) return;
            m_CurTime += Time.deltaTime;
            if (m_CurTime > m_CoolTime)
            {
                m_CurTime = 0.0f;
                m_bar.value += 0.05f;
            }
        }
    }

    void Initialize()
    {
        m_CoolTime = 0.5f;
        m_isPlaying = false;
        m_btnStart.onClick.AddListener(OnClicked_BtnStart);
        m_btnStop.onClick.AddListener(OnClicked_BtnStop);
        m_bar.onValueChanged.AddListener(OnValueChanged_Bar);
    }
    void OnValueChanged_Bar(float value)
    {
        m_txtResult.text = PrintValue(value);
    }
    string PrintValue(float value)
    {
        m_txtResult.color = new Color32(0, 0 ,0, (byte)(value * 255)); 
        return string.Format("{0:0.00}",value);
    }
    void OnClicked_BtnStart()
    {
        m_isPlaying=true;
    }
    void OnClicked_BtnStop()
    {
        m_isPlaying = false;
    }
}
