using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mission3 : MonoBehaviour
{
    public Text inputText, keyCode;

    Animator anim;
    PlayerCtrl playerCtrl_script;
    MissionCtrl missionCtrl_script;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        missionCtrl_script = FindObjectOfType<MissionCtrl>();

    }

    // 미션 시작
    public void MissionStart()
    {
        anim.SetBool("isUp", true);
        playerCtrl_script = FindObjectOfType<PlayerCtrl>();

        // 초기화
        inputText.text = "";
        keyCode.text = "";

        // keyCode 랜덤
        for(int i = 0; i < 5; i++)
        {
            keyCode.text += Random.Range(0, 10);
        }
    }

    // x버튼 누르면 호출
    public void ClickCancle()
    {
        anim.SetBool("isUp", false);
        playerCtrl_script.MissionEnd();
    }

    // 숫자 버튼 누르면 호출
    public void ClickNumber()
    {
        if(inputText.text.Length <= 4)
        {
            inputText.text += EventSystem.current.currentSelectedGameObject.name;
        }
    }

    // 삭제 버튼 누르면 호출
    public void ClickDelete()
    {
        if(inputText.text != "")
        {
            inputText.text = inputText.text.Substring(0, inputText.text.Length - 1);
        }
    }

    // 체크 버튼 누르면 호출
    public void ClickCheck()
    {
        if(inputText.text == keyCode.text)
        {
            MissionSuccess();
        }
    }

    // 미션 성공하면 호출
    public void MissionSuccess()
    {
        ClickCancle();
        missionCtrl_script.MissionSuccess(GetComponent<CircleCollider2D>());
    }
}

