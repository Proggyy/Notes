using System;

namespace NotesApp
{
    public class Note
    {
        /// <summary>
        /// Заголовок заметки
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// Дата создания заметки
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Текст заметки
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// Пустой конструктор для сериализации
        /// </summary>
        public Note() { }
        /// <summary>
        /// Конструктор заметки
        /// </summary>
        /// <param name="header">Заголовок</param>
        /// <param name="noteText">Текст заметки</param>
        public Note(string header, string noteText)
        {
            Header = header;
            NoteText = noteText;
            Date = DateTime.Now;
        }
    }
}
