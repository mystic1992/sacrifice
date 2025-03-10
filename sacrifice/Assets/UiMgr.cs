
using System;
using System.Collections.Generic;
using UnityEngine;


public class UiMgr: MonoBehaviour {
    public static UiMgr instance;

    public List<WndInfo> wndList = new List<WndInfo>();

    private void Awake() {
        instance = this;
    }

    public void ShowWnd(string name) {
        for(int i = 0; i < wndList.Count; i++) {
            if (wndList[i].name == name) {
                wndList[i].wnd.gameObject.SetActive(true);
            } else {
                wndList[i].wnd.gameObject.SetActive(false);
            }
        }
    }
}
[Serializable]
public class WndInfo {
    public string name;
    public Transform wnd;
}


