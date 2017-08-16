#region License
/*
 * TestSocketIO.cs
 *
 * The MIT License
 *
 * Copyright (c) 2014 Fabio Panettieri
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using System.Collections;
using UnityEngine;
using SocketIO;

public class NetWorkManager : MonoBehaviour
{
    private SocketIOComponent socket;

    /// <summary>
    /// 启动
    /// </summary>
    public void Start()
    {
        GameObject go = GameObject.Find("SocketIO");
        socket = go.GetComponent<SocketIOComponent>();
        socket.url = "ws://localhost:8765";

        socket.Connect();

        socket.On("login_result", OnLoginResult);
        socket.On("login_finished", OnLoginFinish);
    }

    //更新
    private void Update()
    {

    }

    //HTTP请求回调

    public void OnLoginAccountSuccess()
    {

    }

    public void OnLoginAccountFailded() {

    }

    public void OnLoginHallSuccess()
    {

    }

    public void OnLoginHallFailed()
    {

    }

    //socket 事件
    public void OnLoginResult(SocketIOEvent e) {
        Debug.Log("on " + e.name + "----->" + e.data);
    }

    public void OnLoginFinish(SocketIOEvent e) {
        Debug.Log("on " + e.name + "----->" + e.data);
    }

    

}
