using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CodeIsle.LibIpsNet;
namespace TinyIps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            try
            {

                string command = string.Empty;

                string patch = string.Empty;
                string target = string.Empty;

                string original = string.Empty;
                string modified = string.Empty;

                string output = string.Empty;

                if (args.Length > 4 || args.Length == 0)
                {
                    PrintUsage();
                    return;
                }

                command = args[0];
             
                switch(command)
                {
                    case "apply":
                    case "a":
                        

                        if (args.Length > 2)
                        {
                            patch = args[1];
                            target = args[2];
                        }
                        else
                        {
                            PrintUsage();
                            return;
                        }

                        if(args.Length > 3) 
                        {
                            output = args[3];
                        }

                        if (output == string.Empty)
                        {
                            output = target;
                        }

                        Patcher patcher = new Patcher();

                        patcher.Patch(patch, target, output);

                        return;
                    case "create":
                    case "c":

                        if (args.Length == 4)
                        {
                            original = args[1];
                            modified = args[2];
                            output = args[3];
                        }
                        else
                        {
                            PrintUsage();
                            return;
                        }
                        Creator creator = new Creator();
                        creator.Create(original, modified, output);
                        return;
                }
                PrintUsage();
                return;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        static void PrintUsage()
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            Console.WriteLine("{0} {1}", versionInfo.ProductName, versionInfo.ProductVersion.ToString());
            Console.WriteLine("{0}", versionInfo.LegalCopyright);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Usage:");
            Console.WriteLine("tinyips apply|a <patch> <target> [<output>]");
            Console.WriteLine("tinyips create|c <original> <modified> <output>");
            // Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().get)
        }
    }
}
