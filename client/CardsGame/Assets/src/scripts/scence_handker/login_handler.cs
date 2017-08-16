using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using http_service.httpd;
using utils;
using System;
using System.Collections.Generic;

public class login_handler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var t = TimeHelp.GetTimeStamp(DateTime.Now,10);
        Debug.Log(t);

        JSONObject js = new JSONObject();
        js.AddField("a", "bbbb");
        js.AddField("b", new JSONObject("{\"name\":\"zh\",\"age\":10}"));
        Debug.Log(httpd.make_sign(js));
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnLoginClick()
    {
        Debug.Log("login button click.");
       
    }
    /// <summary>
    /// 登录成功回调
    /// </summary>
    void OnLoginSuccess() {
        SceneManager.LoadScene("hall", LoadSceneMode.Additive);
    }

    /// <summary>
    /// 登录失败回调
    /// </summary>
    void OnLoginFailed() {

    }
}

