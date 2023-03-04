using System.Windows;
namespace NotesApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Передача контекста представлению
            DataContext = new NotesViewModel(this, NotesList);
        }
    }
}
