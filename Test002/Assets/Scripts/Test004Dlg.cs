using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test004Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public Text m_txtResult;
    public Slider m_Slider;

    private void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
        m_Slider.onValueChanged.AddListener(OnValueChanged_Slider);
    }
    void OnClicked_BtnResult()
    {
        m_txtResult.text = $"현재 지정된 값은 {(int)m_Slider.value} 입니다.";
    }
    void OnClicked_BtnClear()
    {
        m_Slider.value = 0;
        m_txtResult.text = string.Empty;
    }
    void OnValueChanged_Slider(float value)
    {
        m_txtResult.text = $"{(int)value}";
    }
}
