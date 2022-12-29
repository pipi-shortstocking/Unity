using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeMainScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("samplescene");
    }

    public void ChangeUnder1Scene(){ // 첫번째 씬
        SceneManager.LoadScene("under1");
    }

    public void ChangeUp1Scene(){// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("up1");
    }

    public void ChangeUnder1CPRlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("under1 cpr level");
    }

    public void ChangeUnder1HAIMlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("under1 haim level");
    }

    public void ChangeUnder1HWAlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("under1 hwa level");
    }

    public void ChangeUnder1YEOLlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("under1 yeol level");
    }

    public void ChangeUp1CPRlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("up1 cpr level");
    }

    public void ChangeUp1HAIMlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("up1 haim level");
    }

    public void ChangeUp1HWAlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("up1 hwa level");
    }

    public void ChangeUp1YEOLlevelScene()
    {// 버튼 누르면 이동될 씬
        SceneManager.LoadScene("up1 yeol level");
    }

}
