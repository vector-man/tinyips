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
            // Print the copyright information.
            PrintCopyright();
            // Set console input encoding to UTF-8
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                // Holds the command line option.
                string option = string.Empty;
                // Holds the path to the patch file.
                string patch = string.Empty;
                // Holds the path to the target file to be patched.
                string target = string.Empty;
                // Holds the path to the original, unaltered file.
                string original = string.Empty;
                // Holds the path to the modified file (with the differences compared to 'original').
                string modified = string.Empty;
                // Holds the path to the output file (te file to write to).
                string output = string.Empty;
                // If this fails, it is known that the parameters are invalid.
                if (args.Length > 4 || args.Length == 0)
                {
                    PrintUsage();
                    return;
                }
                // Assign the option.
                option = args[0];
             
                switch(option)
                {
                    case "apply":
                        // Looking for the format: apply patch target
                        if (args.Length >= 3)
                        {
                            // Assign the path file.
                            patch = args[1];
                            // Assign the target file (this file is overwritten if output is not specified).
                            target = args[2];

                            // Looking for the format: apply patch target output
                            if (args.Length == 4)
                            {
                                // Assign the output file (essentially the target file copied to the output file path and then patched.)
                                output = args[3];
                            }
                            // If the output was not set.
                            if (output == string.Empty)
                            {
                                // Overwriting the target file instead.
                                output = target;
                            }
                            // Create a new Patcher object.
                            Patcher patcher = new Patcher();
                            // Patch the file (output is where the patched file is created).
                            patcher.Patch(patch, target, output);

                            return;
                        }
                        else
                        {
                            // Some invalid values were entered, so print an error.
                            Console.WriteLine("Values must be supplied for option apply.");
                        }

                        break;
                                             
                    case "create":
                        // Looking for the format: create original modified output.
                        if (args.Length == 4)
                        {
                            // Assign the original file.
                            original = args[1];
                            // Assign the modified file.
                            modified = args[2];
                            // Assign the output file (where the patch is written).
                            output = args[3];
                            // Create a new Creator object.
                            Creator creator = new Creator();
                            // Create the patch file (output is where the patched file is created).
                            creator.Create(original, modified, output);
                            return;
                        }
                        else
                        {
                            // Some invalid values were entered, so print an error.
                            Console.WriteLine("Values must be supplied for option create.");
                        }
                        break;
                    default:
                        // Print an error message for an option that doesn't exist.
                        Console.WriteLine("Bad option {0}.", option);
                        break;
                }
                // Print the usage information.
                PrintUsage();
                return;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        static void PrintCopyright()
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            Console.WriteLine("{0} {1}", versionInfo.ProductName, versionInfo.ProductVersion.ToString());
            Console.WriteLine("{0}", versionInfo.LegalCopyright);
            Console.WriteLine("");
        }
        static void PrintUsage()
        {
            Console.WriteLine("");
            Console.WriteLine("Usage:");
            Console.WriteLine("tinyips apply <patch> <target> [<output>]");
            Console.WriteLine("tinyips create <original> <modified> <output>");
        }
    }
}
