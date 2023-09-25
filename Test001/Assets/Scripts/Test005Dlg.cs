using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test005Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public Text[] m_txtSilderValue;
    public Text m_txtResult;
    public Slider[] m_Sliders;
    public Color32 m_Color;

    private void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
        for(int i = 0; i < m_Sliders.Length; i++)
        {
            int idx = i;
            m_Sliders[idx].onValueChanged.AddListener((float value) => OnValueChanged_Sliders(value, idx));
        }
    }

    void OnValueChanged_Sliders(float value, int idx)
    {
        Color32 color = m_txtResult.color;
        m_txtResult.text = "현재 색상";
        switch(idx)
        {
            case 0: color.r = (byte)value; m_txtSilderValue[0].text = $"{(int)value}"; break;
            case 1: color.g = (byte)value; m_txtSilderValue[1].text = $"{(int)value}"; break;
            case 2: color.b = (byte)value; m_txtSilderValue[2].text = $"{(int)value}"; break;
        }
        m_Color = color;
        m_txtResult.color = color;
    }
    void OnClicked_BtnResult()
    {
        m_txtResult.text = $"현재색상 => ({m_Color.r}, {m_Color.g}, {m_Color.b})";
    }
    void OnClicked_BtnClear()
    {
        m_txtResult.text = "초기화";
        m_txtResult.color = new Color32(0, 0, 0, 255);
        m_Sliders[0].value = 0;
        m_Sliders[1].value = 0;
        m_Sliders[2].value = 0;
    }
}
