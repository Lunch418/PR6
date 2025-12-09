using System.Windows;

namespace RegIN
{
    public partial class MainWindow : Window
    {
        // Статическое свойство для доступа из любых страниц
        public static MainWindow mainWindow { get; private set; }

        // Пользователь для авторизации
        public Classes.User UserLogin { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Устанавливаем статическую ссылку
            mainWindow = this;

            // Инициализируем объект пользователя
            UserLogin = new Classes.User();

            // Открываем начальную страницу (например, Login или Regin)
            OpenPage(new Pages.Login());
        }

        // Метод для смены страниц
        public void OpenPage(System.Windows.Controls.Page page)
        {
            frame.Content = page;
        }
    }
}