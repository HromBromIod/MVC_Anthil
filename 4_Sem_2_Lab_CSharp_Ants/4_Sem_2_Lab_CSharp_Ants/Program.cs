using System;
using System.Windows.Forms;
using _4_Sem_2_Lab_CSharp_Ants.Controller;

namespace _4_Sem_2_Lab_CSharp_Ants
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// 
        /// Голукович Тимофей
        /// 2 курс 9 группа
        /// Лабораторная работа №2: 16. Муравейник
        /// 
        /// Model: муравейник
        /// View: windows-форма, отрисовывающая логическую работу муравейника
        /// Controller: класс, связывающий работу модели(муравейника) и view(windows-формы)
        /// 
        /// Многопоточность реализуется в классах Anthill и MainForm
        /// 
        /// Исключения используются в классах Queen, Larva, Pest, SoldierAnt, PoliceAnt, WorkerAnt
        /// 
        /// Шаблон фабрика - используется в классе Larva
        /// Шаблон наблюдатель - используется во многих классах(Anthill, MainForm, Insect, FoodStorage и др.)
        /// 
        /// Приложение может долго работать и загружаться,
        /// т.к. создание новых потоков в большом количестве очень сильно нагружает компьютер
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Запуск контроллера, который запускает модель и view
            ApplicationController controller = new ApplicationController();
            controller.Start(); 
        }
    }
}
