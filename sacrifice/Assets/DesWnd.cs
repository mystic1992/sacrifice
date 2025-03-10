using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesWnd : MonoBehaviour {
    public Button closeBtn;
    public Text desTxt;

    // Start is called before the first frame update
    void Start() {
        closeBtn.onClick.AddListener(OnCloseBtnBtnClick1);
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCloseBtnBtnClick1() {
        UiMgr.instance.ShowWnd("main");
    }
}

