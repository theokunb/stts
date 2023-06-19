using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private TtsView _ttsView;
    [SerializeField] private SttView _sttView;

    private List<IMenu> _menus;

    private void Awake()
    {
        _menus = new List<IMenu>();

        _ttsView.Init(new TtsViewModel());
        _sttView.Init(new SttViewModel());

        _menus.Add(_ttsView);
        _menus.Add(_sttView);

        Open(_menus.First().Name);
    }

    public void Open(string title)
    {
        if (_menus.Any(element => element.Name == title) == false)
        {
            return;
        }

        foreach (var menu in _menus)
        {
            if(menu.Name == title)
            {
                menu.Open();
            }
            else
            {
                menu.Close();
            }
        }
    }
}
