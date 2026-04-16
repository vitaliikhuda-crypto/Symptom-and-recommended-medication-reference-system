using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MedSearchWPF.Models;

public class Medicine : INotifyPropertyChanged
{
    private string _name        = string.Empty;
    private string _description = string.Empty;
    private string _dose        = string.Empty;
    private string _icon        = "💊";

    public string Name
    {
        get => _name;
        set { if (_name != value) { _name = value; OnPropertyChanged(); } }
    }

    public string Description
    {
        get => _description;
        set { if (_description != value) { _description = value; OnPropertyChanged(); } }
    }

    public string Dose
    {
        get => _dose;
        set { if (_dose != value) { _dose = value; OnPropertyChanged(); } }
    }

    public string Icon
    {
        get => _icon;
        set { if (_icon != value) { _icon = value; OnPropertyChanged(); } }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
