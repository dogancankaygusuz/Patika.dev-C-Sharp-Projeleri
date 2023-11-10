using System;
using System.Drawing;
using ZXing;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Barcode Üret");
        Console.WriteLine("2. Barcode Oku");
        Console.Write("Seçiminizi yapın (1 veya 2): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GenerateAndSaveBarcode();
                break;
            case "2":
                ReadBarcodeFromFile();
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }
    static void GenerateAndSaveBarcode()
    {
        Console.Write("Barcode içeriğini girin: ");
        string content = Console.ReadLine();

        BarcodeWriter barcodeWriter = new BarcodeWriter();
        barcodeWriter.Format = BarcodeFormat.QR_CODE;

        Image barcodeImage = barcodeWriter.Write(content);

        Bitmap barcodeBitmap = new Bitmap(barcodeImage);

        Console.Write("Dosya adı girin: ");
        string fileName = Console.ReadLine();
        barcodeBitmap.Save($"{fileName}.png");

        Console.WriteLine($"Barcode başarıyla oluşturuldu ve {fileName}.png olarak kaydedildi.");
    }

    static void ReadBarcodeFromFile()
    {
        Console.Write("Dosya adını girin: ");
        string fileName = Console.ReadLine();

        BarcodeReader barcodeReader = new BarcodeReader();

        // Image.FromFile kullanarak resmi yükle
        using (var stream = new FileStream($"{fileName}.png", FileMode.Open))
        {
            using (var image = Image.FromStream(stream))
            {
                // Image'ı Bitmap'e dönüştür
                Bitmap barcodeBitmap = new Bitmap(image);

                var result = barcodeReader.Decode(barcodeBitmap);

                if (result != null)
                {
                    Console.WriteLine($"Okunan Barcode: {result.Text}");
                }
                else
                {
                    Console.WriteLine("Barcode okunamadı.");
                }
            }
        }
    }
}
