using System;

public class PluginFacade
{
    private Test _plugin;

    public event Action<string> Result;

    public PluginFacade()
    {
        _plugin = new Test();
    }

    public void Speak(string text)
    {
        _plugin.Speak(text);
    }

    public void Speach()
    {
        _plugin.OnSttResult += OnResult;
        _plugin.Speech();
    }

    private void OnResult(string obj)
    {
        Result?.Invoke(obj);
    }
}
