using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test006Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public Text m_txtResult;
    public Scrollbar m_Scrollbar;
    private void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        m_Scrollbar.onValueChanged.AddListener(OnValueChanged_Scrollbar);
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
    }
    void OnValueChanged_Scrollbar(float value)
    {
        m_txtResult.text = value.ToString();
    }
    void OnClicked_BtnResult()
    {
        m_txtResult.text = $"현재 진행된 값은 <color=#FFC200>{string.Format("{0:0.00}",m_Scrollbar.value)}</color> 입니다.";
    }
    void OnClicked_BtnClear()
    {
        m_Scrollbar.value = 0;
        m_txtResult.text = string.Empty;
    }
}
