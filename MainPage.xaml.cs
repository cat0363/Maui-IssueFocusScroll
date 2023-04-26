using System.Collections.ObjectModel;

namespace Maui_IssueFocusScroll;

public partial class MainPage : ContentPage
{
    public ObservableCollection<ViewModelTest> pVmTest = new ObservableCollection<ViewModelTest>();

    public MainPage()
    {
        InitializeComponent();

        for (int i = 0; i < 100; i++)
        {
            pVmTest.Add(new ViewModelTest() { No = i + 1 });
        }
        BindableLayout.SetItemsSource(slTest, pVmTest);
    }
}

public class ViewModelTest
{
    public int No { get; set; }

    public string ItemName { get; set; }
}