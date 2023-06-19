using TMPro;
using UnityEngine;

public class SttView : BaseView<SttViewModel>
{
    [SerializeField] private TMP_Text _text;

    private PluginFacade _plugin;

    private void Start()
    {
        _plugin = new PluginFacade();
    }

    public void OnSpeech()
    {
        _plugin.Result += OnResult;
        _plugin.Speach();
        
    }

    private void OnResult(string obj)
    {
        _plugin.Result -= OnResult;
        _text.text = obj;
    }
}
