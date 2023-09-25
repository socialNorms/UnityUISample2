using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test001Dlg : MonoBehaviour
{
    public Button m_btnResult;
    public Button m_btnClear;
    public InputField m_iptName;
    public Text m_txtName;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
        m_iptName.onSubmit.AddListener(OnSubmit_IptName);
    }

    void OnSubmit_IptName(string value)
    {
        string name = $"<color=#FF0000>{value}</color>";
        m_txtName.text = $"<color=#0027FF>입력이 완료되었습니다.</color> ({name})";
    }

    void OnClicked_BtnResult()
    {
        string text = $"<color=#0027FF>당신이 입력한 이름은</color> <color=#FF0000>{m_iptName.text}</color> <color=#0027FF>입니다</color>";
        m_txtName.text = text;
    }

    void OnClicked_BtnClear()
    {
        m_txtName.text = $"<color=#0027FF>이름을 입력하세요</color>";
        m_iptName.text = string.Empty;
    }
}
