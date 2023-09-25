using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test008Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public Dropdown m_dropdown;
    public Text m_txtResult;
    private void Start()
    {
        Initialize();
    }
    public void Initialize()
    {
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
        m_dropdown.onValueChanged.AddListener(OnValueChanged_Dropdown);
    }
    void OnValueChanged_Dropdown(int value)
    {
        m_txtResult.text = m_dropdown.options[value].text;
    }
    void OnClicked_BtnResult()
    {
        string city = m_dropdown.options[m_dropdown.value].text;
        m_txtResult.text = $"당신이 선택한 도시는 <color=#FF0000>{city}</color> 입니다.";
    }
    void OnClicked_BtnClear()
    {
        m_dropdown.value = 0;
        m_txtResult.text = m_dropdown.options[m_dropdown.value].text;
    }
}
