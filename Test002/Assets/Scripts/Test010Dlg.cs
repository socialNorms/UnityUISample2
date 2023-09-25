using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test010Dlg : MonoBehaviour
{
    public Button m_btnResult, m_btnClear;
    public ScrollRect m_ScrollView;
    public Text m_txtResult;
    public Transform m_ItemPrefab;
    public string[] m_Citys = new string[] {"전주", "서울", "울산", "청주", "나주", "익산", "계룡", "송천동", "고담", "헤네시스", "라스베이거스" };
    public List<ItemText> m_ItemList = new List<ItemText>();
    public ItemText m_CurItem = null;
    public bool m_Select = false;

    private void Start()
    {
        Initialize();
    }
    void Initialize()
    {
        for ( int i = 0; i < m_Citys.Length; i++)
        {
            string text = m_Citys[i];
            SpawnItem(i, text);
        }
        m_btnResult.onClick.AddListener(OnClicked_BtnResult);
        m_btnClear.onClick.AddListener(OnClicked_BtnClear);
    }
    void SpawnItem(int i, string text)
    {
        GameObject go = Instantiate(m_ItemPrefab.gameObject, m_ScrollView.content);
        go.GetComponent<ItemText>().Initialize(i, text);
        m_ItemList.Add(go.GetComponent<ItemText>());
        int idx = i;
        go.GetComponent<Button>().onClick.AddListener(() => OnClicked_BtnItem(idx));
    }
    void OnClicked_BtnItem(int i)
    {
        ItemText item = m_ItemList[i];
        ChangeItemTextColor(item);
        m_txtResult.text = item.m_txtItem.text;
    }
    void OnClicked_BtnResult()
    {
        if (m_CurItem == null) return;
        string city = m_CurItem.m_txtItem.text;
        m_txtResult.text = $"당신이 선택한 도시는 <color=#FF0000>{city}</color> 입니다.";
    }
    void OnClicked_BtnClear()
    {
        m_Select = false;
        m_CurItem = null;
        ClearItemColor();
        m_txtResult.text = "도시를 선택하세요";
    }
    void ChangeItemTextColor(ItemText item)
    {
        if (!m_Select)
        {
            m_CurItem = item;
            item.m_txtItem.color = Color.red;
            m_Select = true;
        }
        else
        {
            m_CurItem.m_txtItem.color = Color.black;
            m_CurItem = item;
            m_CurItem.m_txtItem.color = Color.red;
        }
    }
    void ClearItemColor()
    {
        foreach (ItemText item in m_ItemList)
            item.m_txtItem.color = Color.black;
    }
    private void OnDestroy()
    {
        ClearPrefabList();
    }
    void ClearPrefabList()
    {
        for (int i = 0; i < m_ItemList.Count; i++)
        {
            ItemText item = m_ItemList[i];
            Destroy(item.gameObject);
        }
    }
}
