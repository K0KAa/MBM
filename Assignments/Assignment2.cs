//QQ create a folder "ABC" ,create 10 subfolders in "ABC".Each subfolder should contain 
//a C# file with hello world program.


using System.IO;
using System;
using System.Text;

public class Directories
{
    public void CreateDirectories()
    {
        string directoryName = @"D:\git\Netcentric\MBM A\Kushal.Kattel";
        string subDirectoryName="Subfolder";
        string helloworldprogram = @"using System; 

                                    namespace Assignment_2
                                    {
                                        class Program
                                        {
                                            static void Main(string[] args)
                                            {
                                                Console.WriteLine( ""Hello World!"");
                                            }
                                        }
                                    }  "; //storing hellow world program data as string
        byte[] bytes =  Encoding.UTF8.GetBytes(helloworldprogram);// converting to bytes 
                                                                //to perform stream write
        
        Directory.CreateDirectory(directoryName); //creating parent directory
        for(int i=1;i<=10;i++) //creating 10 sub directories
        {
            string tempsubDirectoryName=$"{directoryName}/{subDirectoryName+i}";
            Directory.CreateDirectory(tempsubDirectoryName);
            string fileName = $"{directoryName}/{subDirectoryName+i}/Helloworld.cs";
            // creating helloworld program inside subdirectories
            // Writing code in each program files
            using (var stream = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            { //using stream writer method to write th file
               try{ 
                    
                        stream.Write(bytes,0,bytes.Length);
                    } 
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
               
               
            }
         
        }
        Console.WriteLine("Created folders and files sucessfully");
    }
}