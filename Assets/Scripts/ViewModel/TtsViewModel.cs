public class TtsViewModel : BaseViewModel
{
    private PluginFacade _plugin;

    public TtsViewModel()
    {
        _plugin = new PluginFacade();
    }

    public void SpeakCommand(string text)
    {
        _plugin.Speak(text);
    }
}
