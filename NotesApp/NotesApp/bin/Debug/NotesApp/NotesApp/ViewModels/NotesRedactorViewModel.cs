using System.Windows;
using System.Windows.Input;


namespace NotesApp
{
    public class NotesRedactorViewModel
    {
        #region Приватные поля
        Window window;
        #endregion

        #region Команды
        public ICommand CloseCommand { get; set; }
        public ICommand MinimizeCommand { get; set; }
        #endregion

        /// <summary>
        /// Конструктор модели представления
        /// </summary>
        /// <param name="window">Главное окно</param>
        /// <param name="listView">Графический список элементов</param>
        public NotesRedactorViewModel(Window window)
        {
            this.window = window; 

            CloseCommand = new Command(() => this.window.Close());
            MinimizeCommand = new Command(() => window.WindowState = WindowState.Minimized);
        }
    }
}
