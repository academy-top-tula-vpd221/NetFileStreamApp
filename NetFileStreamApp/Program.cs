using System.Text;

string fileName = @"X:\RPO\maxim efimov\file01.dat";

//using(BinaryWriter bwriter = new BinaryWriter(File.Open(fileName, FileMode.Create)))
//{
//    bwriter.Write("Hello");
//    bwriter.Write(100);
//    bwriter.Write(123.456);
//}

using(BinaryReader breader = new BinaryReader(File.OpenRead(fileName)))
{
    string s = breader.ReadString();
    int n = breader.ReadInt32();
    double x = breader.ReadDouble();

    Console.WriteLine($"{n} {x}");
}


void StreamWriterReader()
{
    string text1 = "Some information relates to prerelease product that may be substantially modified before it’s released. Microsoft makes no warranties, express or implied, with respect to the information provided here.";
    string text2 = "Initializes a new instance of the StreamWriter class for the specified file by using the default encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.";


    //using(StreamWriter writer = new StreamWriter(fileName, true))
    //{
    //    writer.WriteLine(text1);
    //    writer.WriteLine(text2);
    //}

    using (StreamReader reader = new StreamReader(fileName))
    {
        //string text = reader.ReadToEnd();
        //Console.WriteLine(text);


        //string? line;
        //while((line = reader.ReadLine()) != null)
        //    Console.WriteLine(line);

        int position = 5;
        int size = 20;

        for (int i = 0; i < position; i++)
            reader.Read();

        char[] chars = new char[size];
        reader.Read(chars, 0, size);

        string s = new string(chars);
        Console.WriteLine(s);
    }
}

void FileStreamExample()
{

    //FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);

    //FileStream stream1 = File.Open(fileName, FileMode.OpenOrCreate);
    //FileStream stream2 = File.OpenRead(fileName);
    //FileStream stream3 = File.OpenWrite(fileName);

    //FileInfo fileInfo = new FileInfo(fileName);

    //FileStream stream4 = fileInfo.Create();
    //FileStream stream5 = fileInfo.Open(FileMode.OpenOrCreate);
    //FileStream stream6 = fileInfo.OpenRead();
    //FileStream stream7 = fileInfo.OpenWrite();

    //string text = "Записывает последовательность байтов в текущий файловый поток из диапазона только для чтения и перемещает текущую позицию внутри файлового потока на число записанных байтов.";

    //using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
    //{
    //    byte[] buffer = Encoding.Default.GetBytes(text);
    //    stream.Write(buffer, 0, buffer.Length);
    //}

    //using(FileStream stream = File.OpenRead(fileName))
    //{
    //    byte[] buffer = new byte[stream.Length];
    //    stream.Read(buffer, 0, buffer.Length);

    //    string textRead = Encoding.Default.GetString(buffer);
    //    Console.WriteLine(textRead);
    //}

    //using(FileStream stream = File.OpenRead(fileName))
    //{
    //    stream.Seek(-40, SeekOrigin.End);
    //    byte[] buffer = new byte[40];
    //    stream.Read(buffer, 0, buffer.Length);

    //    string textRead = Encoding.Default.GetString(buffer);
    //    Console.WriteLine(textRead);
    //}

    //using(FileStream stream = File.OpenWrite(fileName))
    //{
    //    stream.Seek(20, SeekOrigin.Begin);
    //    stream.Write(Encoding.Default.GetBytes("Hello"));
    //}

    //using (FileStream stream = File.Open(fileName, FileMode.Open))
    //{
    //    int position = 20;
    //    stream.Seek(position, SeekOrigin.Begin);

    //    byte[] buffer = new byte[stream.Length - position];
    //    stream.Read(buffer, 0, buffer.Length);

    //    Console.WriteLine(Encoding.Default.GetString(buffer));

    //    stream.Seek(position, SeekOrigin.Begin);
    //    stream.Write(Encoding.Default.GetBytes("Hello"));
    //    stream.Write(buffer, 0, buffer.Length);
    //}

    //using(FileStream stream = File.Open(fileName, FileMode.Append))
    //{
    //    string textAppend = "Some information relates to prerelease product that may be substantially modified before it’s released. Microsoft makes no warranties, express or implied, with respect to the information provided here.";

    //    byte[] buffer = Encoding.Default.GetBytes(textAppend);
    //    stream.Write(buffer, 0, buffer.Length);
    //}

}