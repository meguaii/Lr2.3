using System;


class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}


class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}


class ExpertDocumentWorker : ProDocumentWorker
{
    public void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите ключ доступа Pro: ");
        string proKey = Console.ReadLine();
        Console.Write("Введите ключ доступа Expert: ");
        string expertKey = Console.ReadLine();

        DocumentWorker documentWorker;

        if (string.IsNullOrEmpty(proKey) && string.IsNullOrEmpty(expertKey))
        {
            documentWorker = new DocumentWorker();
        }
        else if (!string.IsNullOrEmpty(proKey) && string.IsNullOrEmpty(expertKey))
        {
            documentWorker = new ProDocumentWorker();
        }
        else
        {
            documentWorker = new ExpertDocumentWorker();
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}
