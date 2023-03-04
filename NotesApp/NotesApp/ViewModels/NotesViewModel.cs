using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Serialization;

namespace NotesApp
{
    public class NotesViewModel
    {
        #region Приватные поля
        Window window;
        ListView ListView;
        BindingList<Note> notes;
        XmlSerializer xmls = new XmlSerializer(typeof(BindingList<Note>));
        #endregion

        #region Команды
        public ICommand CloseCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CheckCommand { get; set; }
        public ICommand MinimizeCommand { get; set; }
        #endregion

        /// <summary>
        /// Конструктор модели представления
        /// </summary>
        /// <param name="window">Главное окно</param>
        /// <param name="listView">Графический список элементов</param>
        public NotesViewModel(Window window, ListView listView)
        {
            if (File.Exists("notes.xml"))
            {
                notes = Deserialize();
            }
            else
            {
                notes = new BindingList<Note>();
            }
            this.window = window;
            ListView = listView;
            ListView.ItemsSource = notes;

            CloseCommand = new Command(() =>
            {
                Serialize();
                this.window.Close();
            });
            MinimizeCommand = new Command(() => window.WindowState = WindowState.Minimized);
            DeleteCommand = new Command(() =>
            {
                if (ListView.SelectedIndex != -1)
                {
                    notes.RemoveAt(ListView.SelectedIndex);
                }
            });

            AddCommand = new Command(() => notes.Add(new Note("new", "")));

            CheckCommand = new Command(() => OpenNoteEditor());
        }

        #region Методы
        /// <summary>
        /// Открывает окно просмотра и редактирования
        /// </summary>
        private void OpenNoteEditor()
        {
            if (ListView.SelectedIndex == -1)
            {
                return;
            }
            CheckWindow checkWindow = new CheckWindow();
            checkWindow.text.Text = notes[ListView.SelectedIndex].Header;
            checkWindow.desc.Text = notes[ListView.SelectedIndex].NoteText;

            checkWindow.SaveButton.Command = new Command(() =>
            {
                notes[ListView.SelectedIndex] = new Note(checkWindow.text.Text, checkWindow.desc.Text);
                checkWindow.Close();
            });
            checkWindow.BackButton.Command = new Command(() => checkWindow.Close());

            checkWindow.Show();
        }

        /// <summary>
        /// Сериализует коллекцию элементов
        /// </summary>
        private void Serialize()
        {
            XmlSerializer xmls = new XmlSerializer(typeof(BindingList<Note>));
            using (FileStream fs = new FileStream("notes.xml", FileMode.OpenOrCreate))
                {
                    xmls.Serialize(fs, notes);
                }
        }

        /// <summary>
        /// Достает коллекцию элементов из xml документа
        /// </summary>
        /// <returns>Коллекция элементов из xml документа</returns>
        private BindingList<Note> Deserialize()
        {
            XmlSerializer xmls = new XmlSerializer(typeof(BindingList<Note>));
            BindingList<Note> DeserializedList = new BindingList<Note>();
            using (FileStream fs = new FileStream("notes.xml", FileMode.OpenOrCreate))
            {
                DeserializedList = xmls.Deserialize(fs) as BindingList<Note>;
            }
            return DeserializedList;
        }
        #endregion
    }
}