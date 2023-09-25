using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test009Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public Text m_txtResult;
    public Dropdown m_dropdown;

    private void Start()
    {
        Initialize();
    }
    void Initialize()
    {
        Dropdown.OptionData data1 = new Dropdown.OptionData("����");
        Dropdown.OptionData data2 = new Dropdown.OptionData("����");
        Dropdown.OptionData data3 = new Dropdown.OptionData("û��");
        Dropdown.OptionData data4 = new Dropdown.OptionData("����");
        Dropdown.OptionData data5 = new Dropdown.OptionData("����");
        m_dropdown.options.Add(data1);
        m_dropdown.options.Add(data2);
        m_dropdown.options.Add(data3);
        m_dropdown.options.Add(data4);
        m_dropdown.options.Add(data5);
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
        m_dropdown.onValueChanged.AddListener(OnValueChanged_Dropdown);
    }
    void OnClicked_BtnResult()
    {
        string text = $"{m_dropdown.options[m_dropdown.value].text}";
        m_txtResult.text = $"����� ������ ���ô� <color=$FF0000>{text}</color> �Դϴ�.";
    }
    void OnClicked_BtnClear()
    {
        m_dropdown.value = 0;
        m_txtResult.text = $"{m_dropdown.options[m_dropdown.value].text}";
    }
    void OnValueChanged_Dropdown(int value)
    {
        string text = $"{m_dropdown.options[value].text}";
        m_txtResult.text = $"{text}";
    }
}
