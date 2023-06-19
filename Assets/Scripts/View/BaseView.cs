using UnityEngine;

public class BaseView<T> : MonoBehaviour, IMenu where T : BaseViewModel
{
    protected T ViewModel { get; private set; }

    public string Name => GetType().Name;

    public void Init(T viewModel)
    {
        ViewModel = viewModel;
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }
}
