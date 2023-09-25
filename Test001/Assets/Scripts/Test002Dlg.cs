using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test002Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public Toggle[] m_togs;
    public Text m_txtResult;
    public string[] m_txts = new string[3];

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
    }

    void OnValueChanged_Togs(bool value, int idx)
    {
        switch (idx)
        {
            case 0:
                {
                    if (value)
                    {
                        m_txts[0] = "사과 ";
                        m_txtResult.text = "사과";
                    }
                    else
                    {
                        m_txts[0] = string.Empty;
                        m_txtResult.text = string.Empty;
                    }
                    break;
                }
            case 1:
                {
                    if (value)
                    {
                        m_txts[1] = "배 ";
                        m_txtResult.text = "배";
                    }
                    else
                    {
                        m_txts[1] = string.Empty;
                        m_txtResult.text = string.Empty;
                    }
                    break;
                }
            case 2:
                {
                    if (value)
                    {
                        m_txts[2] = "오렌지 ";
                        m_txtResult.text = "오렌지";
                    }
                    else
                    {
                        m_txts[2] = string.Empty;
                        m_txtResult.text = string.Empty;
                    }
                    break;
                }
        }
        Debug.Log(idx);
    }

    void OnClicked_BtnResult()
    {
        string text = string.Empty;
        foreach (string item in m_txts)
            text += item;
        if (text == string.Empty)
            m_txtResult.text = $"<color=#FF002D>당신이 선택한 과일은 없습니다.</color>";
        else
            m_txtResult.text = $"<color=#FF002D>당신이 선택한 과일은</color> <color=#000CFF>{text}</color> <color=#FF002D>입니다.</color>";
    }
    void OnClicked_BtnClear()
    {
        for (int i = 0; i < m_txts.Length; i++)
            m_txts[i] = string.Empty;
        m_txtResult.text = string.Empty;
    }
}
