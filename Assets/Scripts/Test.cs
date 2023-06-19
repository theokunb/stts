using System;
using UnityEngine;

public class Test
{
    private const string ActivityName = "com.example.unity.MyPlugin";

    private AndroidJavaObject _activity;
    private PluginCallback _callback;

    public event Action<string> OnSttResult;

    public Test()
    {
        _activity = new AndroidJavaObject(ActivityName);
        _callback = new PluginCallback();
        SetCallback(_callback);
        _callback.Test = this;
    }

    public void Speak(string text)
    {
        _activity.Call("Speak", text);
    }

    public void Speech()
    {
        _activity.Call("StartSpeech");
    }

    public void OnSpeechResult(string text)
    {
        OnSttResult?.Invoke(text);
    }

    private void SetCallback(PluginCallback pluginCallback)
    {
        _activity.Call("SetPluginCallback", pluginCallback);
    }
}

public class PluginCallback : AndroidJavaProxy
{
    public PluginCallback() : base("com.example.unity.PluginCallback") { }

    public Test Test { get; set; }

    public void OnResult(string text)
    {
        Test.OnSpeechResult(text);
    }
}