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
        m_txtName.text = $"<color=#0027FF>�Է��� �Ϸ�Ǿ����ϴ�.</color> ({name})";
    }

    void OnClicked_BtnResult()
    {
        string text = $"<color=#0027FF>����� �Է��� �̸���</color> <color=#FF0000>{m_iptName.text}</color> <color=#0027FF>�Դϴ�</color>";
        m_txtName.text = text;
    }

    void OnClicked_BtnClear()
    {
        m_txtName.text = $"<color=#0027FF>�̸��� �Է��ϼ���</color>";
        m_iptName.text = string.Empty;
    }
}
