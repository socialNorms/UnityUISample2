using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemText : MonoBehaviour
{
    public Button m_btnItem;
    public Text m_txtItem;
    public int m_Index;

    public void Initialize(int idx, string text)
    {
        m_Index = idx;
        m_txtItem.text = text;
    }
}
