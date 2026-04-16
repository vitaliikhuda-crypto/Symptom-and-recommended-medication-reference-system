using System.Collections.ObjectModel;
using System.Windows.Input;
using MedSearchWPF.Models;

namespace MedSearchWPF.ViewModels;

/// <summary>

/// </summary>
public class MedicineEditViewModel : BaseViewModel
{
    private Medicine? _selected;
    public Medicine? Selected
    {
        get => _selected;
        set
        {
            SetProperty(ref _selected, value);
            EditName        = value?.Name        ?? string.Empty;
            EditDescription = value?.Description ?? string.Empty;
            EditDose        = value?.Dose        ?? string.Empty;
            EditIcon        = value?.Icon        ?? "💊";
        }
    }

    private string _editName        = string.Empty;
    private string _editDescription = string.Empty;
    private string _editDose        = string.Empty;
    private string _editIcon        = "💊";

    public string EditName
    {
        get => _editName;
        set => SetProperty(ref _editName, value);
    }

    public string EditDescription
    {
        get => _editDescription;
        set => SetProperty(ref _editDescription, value);
    }

    public string EditDose
    {
        get => _editDose;
        set => SetProperty(ref _editDose, value);
    }

    public string EditIcon
    {
        get => _editIcon;
        set => SetProperty(ref _editIcon, value);
    }

    private string _status = "Оберіть препарат зі списку";
    public string Status
    {
        get => _status;
        set => SetProperty(ref _status, value);
    }

    public ObservableCollection<Medicine> Medicines { get; } = new();

    public ICommand ApplyCommand  { get; }
    public ICommand AddCommand    { get; }
    public ICommand RemoveCommand { get; }

    public MedicineEditViewModel()
    {
        ApplyCommand  = new RelayCommand(_ => ApplyEdit(),       _ => Selected != null);
        AddCommand    = new RelayCommand(_ => AddNew());
        RemoveCommand = new RelayCommand(_ => RemoveSelected(),  _ => Selected != null);

        Medicines.Add(new Medicine { Name = "Парацетамол",  Description = "Жарознижуючий",     Dose = "500 мг", Icon = "💊" });
        Medicines.Add(new Medicine { Name = "Ібупрофен",    Description = "Протизапальний",     Dose = "400 мг", Icon = "💊" });
        Medicines.Add(new Medicine { Name = "Но-шпа",       Description = "Спазмолітик",        Dose = "40 мг",  Icon = "💊" });
        Medicines.Add(new Medicine { Name = "Цитрамон",     Description = "Від головного болю", Dose = "1 табл", Icon = "💊" });
    }

    private void ApplyEdit()
    {
        if (Selected == null) return;
        Selected.Name        = EditName;
        Selected.Description = EditDescription;
        Selected.Dose        = EditDose;
        Selected.Icon        = EditIcon;
        Status = $"✅ Збережено: {Selected.Name}";
    }

    private void AddNew()
    {
        var m = new Medicine { Name = "Новий препарат", Dose = "— мг" };
        Medicines.Add(m);
        Selected = m;
        Status = "➕ Додано новий препарат";
    }

    private void RemoveSelected()
    {
        if (Selected == null) return;
        Medicines.Remove(Selected);
        Selected = null;
        Status = "🗑️ Видалено";
    }
}
