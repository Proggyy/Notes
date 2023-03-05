using System;
using System.Windows.Input;

namespace NotesApp
{
    /// <summary>
    /// Команда для визуальных обьектов
    /// </summary>
    class Command : ICommand
    {
        /// <summary>
        /// Действие команды
        /// </summary>
        Action commandAction;
        public event EventHandler CanExecuteChanged;

        public Command(Action action)
        {
            commandAction = action;
        }
        /// <summary>
        /// Метод, показывающий можно ли вызвать команду
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Метод, вызывающий команду
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            commandAction();
        }
    }
}
