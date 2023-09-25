using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test003Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public Toggle[] m_togs;
    public Text m_txtResult;
    public string text;

    private void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
        for(int i = 0; i < m_togs.Length; i++)
        {
            int idx = i;
            m_togs[i].onValueChanged.AddListener((bool value) => OnValueChanged_Togs(value, idx));
        }
        text = "���";
    }

    void OnValueChanged_Togs(bool value, int idx)
    {
        switch (idx)
        {
            case 0: m_txtResult.text = "���"; text = "���"; break;
            case 1: m_txtResult.text = "��"; text = "��"; break;
            case 2: m_txtResult.text = "������"; text = "������"; break;
        }
    }

    void OnClicked_BtnResult()
    {
        m_txtResult.text = $"����� ������ ������ <color=#0000FF>{text}</color>�Դϴ�.";
    }
    void OnClicked_BtnClear()
    {
        m_txtResult.text = string.Empty;
        text = "���";
    }
}
