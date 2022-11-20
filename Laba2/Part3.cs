using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Globalization; 

namespace Laba2Part3
{
    class Program
    {
        public class DocumentWorker
        {
            public virtual void OpenDocument()
            {
                Console.WriteLine("Документ открыт!");
                Console.WriteLine("\n");
            }
            public virtual void EditDocument()
            {
                Console.WriteLine("!!!Редакирование документа доступно в версии PRO!!!");
                Console.WriteLine("\n");
            }
            public virtual void SaveDocument()
            {
                Console.WriteLine("!!!Сохранение документа доступно в версии Pro!!!");
                Console.WriteLine("\n");
            }
        }
        public class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован!");
                Console.WriteLine("\n");
            }
            public override void SaveDocument()
            {
                Console.WriteLine("!!!Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert!!!");
                Console.WriteLine("\n");
            }
        }
        public class ExpertDocumentWorker : DocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранён в новом формате!");
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string workMode = "";

            Console.WriteLine("Введите ключ активации, если ключа нет просто нажмите enter - ");
            string key = Console.ReadLine();
            switch (key)
            {
                case "1234":
                    workMode = "pro";
                    Console.WriteLine("Верный ключ - версия Pro");
                    break;
                case "5678":
                    workMode = "exp";
                    Console.WriteLine("Верный ключ - версия Expert");
                    break;
                default:
                    Console.WriteLine("Некорректный ключ или ключ не введён, версия программы - Default.");
                    break;
            }

            if (workMode == "")
            {
                DocumentWorker DocApp = new DocumentWorker();
                string mode = "";

                while (mode != "s")
                {
                    Console.WriteLine("Выбирете режим работы:");
                    Console.WriteLine("1 - Открыть документ");
                    Console.WriteLine("2 - Редактировать документ");
                    Console.WriteLine("3 - Сохранить документ");
                    Console.WriteLine("s - Выйти");

                    mode = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (mode == "s")
                    {
                        break;
                    }

                    switch (mode)
                    {
                        case "1":
                            DocApp.OpenDocument();
                            break;
                        case "2":
                            DocApp.EditDocument();
                            break;
                        case "3":
                            DocApp.SaveDocument();
                            break;
                    }
                }
            }
            else if (workMode == "pro")
            {
                ProDocumentWorker DocApp = new ProDocumentWorker();
                string mode = "";

                while (mode != "s")
                {
                    Console.WriteLine("Выбирете режим работы:");
                    Console.WriteLine("1 - Открыть документ");
                    Console.WriteLine("2 - Редактировать документ");
                    Console.WriteLine("3 - Сохранить документ");
                    Console.WriteLine("s - Выйти");

                    mode = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (mode == "s")
                    {
                        break;
                    }

                    switch (mode)
                    {
                        case "1":
                            DocApp.OpenDocument();
                            break;
                        case "2":
                            DocApp.EditDocument();
                            break;
                        case "3":
                            DocApp.SaveDocument();
                            break;
                    }
                }
            }
            else if (workMode == "exp")
            {
                ExpertDocumentWorker DocApp = new ExpertDocumentWorker();
                string mode = "";

                while (mode != "s")
                {
                    Console.WriteLine("Выбирете режим работы:");
                    Console.WriteLine("1 - Открыть документ");
                    Console.WriteLine("2 - Редактировать документ");
                    Console.WriteLine("3 - Сохранить документ");
                    Console.WriteLine("s - Выйти");

                    mode = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (mode == "s")
                    {
                        break;
                    }

                    switch (mode)
                    {
                        case "1":
                            DocApp.OpenDocument();
                            break;
                        case "2":
                            DocApp.EditDocument();
                            break;
                        case "3":
                            DocApp.SaveDocument();
                            break;
                    }
                }
            }
        }
    }
}
