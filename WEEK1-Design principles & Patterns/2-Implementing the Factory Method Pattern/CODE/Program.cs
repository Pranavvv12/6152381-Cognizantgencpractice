using System;

public interface Document{
    void Open();
}
public class WordDocument:Document
{
    public void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}

public class PdfDocument:Document
{
    public void Open()
    {
        Console.WriteLine("Opening Pdf Document");
    }
}

public class ExcelDocument:Document
{
    public void Open()
    {
        Console.WriteLine("Opening Excel Document");
    }
}

public abstract class DocumentFactory
{
   
    public abstract Document CreateDocument();

  
}

public class WordFactory:DocumentFactory
{
   
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfFactory:DocumentFactory
{
    
    public override Document CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelFactory:DocumentFactory
{
    
    public override Document CreateDocument()
    {
        return new ExcelDocument();
    }
}

class Program
{
    static void Main(string[] args){
        DocumentFactory wordFactory = new WordFactory();
        Document word = wordFactory.CreateDocument();
        word.Open();

        DocumentFactory pdfFactory = new PdfFactory();
        Document pdf = pdfFactory.CreateDocument();
        pdf.Open();

        DocumentFactory excelFactory = new ExcelFactory();
        Document excel = excelFactory.CreateDocument();
        excel.Open();

        Console.ReadKey();
    }
}