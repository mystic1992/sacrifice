using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWnd : MonoBehaviour
{
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;

    public GameObject subWnd1;
    public GameObject subWnd2;
    public GameObject subWnd3;
    public GameObject subWnd4;
    // Start is called before the first frame update
    void Start()
    {
        btn1.onClick.AddListener(OnBtnClick1);
        btn2.onClick.AddListener(OnBtnClick2);
        btn3.onClick.AddListener(OnBtnClick3);
        btn4.onClick.AddListener(OnBtnClick4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBtnClick1() {
        subWnd1.SetActive(true);
        subWnd2.SetActive(false);
        subWnd3.SetActive(false);
        subWnd4.SetActive(false);
    }
    private void OnBtnClick2() {
        subWnd1.SetActive(false);
        subWnd2.SetActive(true);
        subWnd3.SetActive(false);
        subWnd4.SetActive(false);
    }
    private void OnBtnClick3() {
        subWnd1.SetActive(false);
        subWnd2.SetActive(false);
        subWnd3.SetActive(true);
        subWnd4.SetActive(false);
    }
    private void OnBtnClick4() {
        subWnd1.SetActive(false);
        subWnd2.SetActive(false);
        subWnd3.SetActive(false);
        subWnd4.SetActive(true);
    }
}
