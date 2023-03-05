using System.Windows;

namespace NotesApp
{
    /// <summary>
    /// Логика взаимодействия для CheckWindow.xaml
    /// </summary>
    public partial class CheckWindow : Window
    {
        public CheckWindow()
        {
            InitializeComponent();
            //Передача контекста представлению
            DataContext = new NotesRedactorViewModel(this);
        }
    }
}
