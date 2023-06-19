using TMPro;
using UnityEngine;

public class TtsView : BaseView<TtsViewModel>
{
    [SerializeField] private TMP_InputField _inputField;

    private PluginFacade _pluginFacade;

    private void Awake()
    {
        _pluginFacade = new PluginFacade();
    }

    public void Speak()
    {
        ViewModel.SpeakCommand(_inputField.text);
    }
}
