// 연령 선택 메뉴에서 버튼 누르기

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick_start : MonoBehaviour
{
    public GameObject start; // 시작메뉴
    public GameObject 무게설정; //무게설정메뉴
    public GameObject 모드선택; //모드선택메뉴
   

    // Start is called before the first frame update
    public void 시작_clicked() // 시작 클릭
    {
        start.SetActive(false); // 연령선택메뉴 안보이게 하고
        무게설정.SetActive(true); // 무게설정 메뉴 보이게
    }
    public void under_clicked() // 1세 이상
    {
        무게설정.SetActive(false); // 무게설정 메뉴 안보이게
        모드선택.SetActive(true); // 모드선택 메뉴 보이게
    }

     public void more_clicked() //1세 미만 눌렀을때 돌아가기 버튼
    {
        무게설정.SetActive(false); // 무게설정 메뉴 안보이게
        모드선택.SetActive(true); // 모드선택 메뉴 보이게
    }

}

   
