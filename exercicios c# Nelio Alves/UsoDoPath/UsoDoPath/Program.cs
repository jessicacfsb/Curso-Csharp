using System;
using System.IO;

namespace UsoDoPath {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\myfolder\file1.txt";  //direção da pasta

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);   //vai exibir o caractere de separação
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);       //mostra qual o caractere que separa os paths
            Console.WriteLine("GetDiretoryName: " + Path.GetDirectoryName(path));   //pega a parte do string correspondente à direção da pasta 
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));    //para pegar o nome do arquivo
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));  //para pegar o nome do arquivo sem a extensão ex: .txt
            Console.WriteLine("GetExtension: "+ Path.GetExtension(path));   //pega apenas a extensão do arquivo ex .txt
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));    //pega o caminho todo do arquivo
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());        //qual a pasta temporaria do sistema pode ser usado para manipular dados temporario de aplicações 
        }
    }
}
