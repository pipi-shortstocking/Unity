using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class onClick_Menu : MonoBehaviour
{
    public GameObject 무게설정;
    public GameObject 모드설정;
    public GameObject start;
 
     public void 시작_clicked()
    {
        start.SetActive(false);
        무게설정.SetActive(true);
    }

    public void 이상_clicked()
    {
        무게설정.SetActive(false);
        모드설정.SetActive(true);
 
    }
    public void 미만_clicked()
    {
        무게설정.SetActive(false);
        모드설정.SetActive(true);
 
    }
    public void back_clicked()
    {
        모드설정.SetActive(false);
        무게설정.SetActive(true);
 
    }
   
}