using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SplitCodeFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFolder = null;
            string filePrefix = String.Empty;
            string generatedFilesFolder = null;

            if (args.Length != 3)
            {
                Console.WriteLine("Usage is: split-files <File Prefix> <Generated Code Folder> <Typed Entity Project>");
                //return;

                filePrefix = "Xrm.Typed.";
                outputFolder = @"C:\Work\repos\epa\typed-entities\src\EPA.TypedEntities\";
                generatedFilesFolder = @"C:\Work\repos\epa\typed-entities\src\EPA.TypedEntities\scripts\";
            }
            else
            {
                filePrefix = args[0];
                outputFolder = args[1];
                generatedFilesFolder = args[2];
            }
            Console.WriteLine($"split-files {filePrefix} {generatedFilesFolder} {outputFolder}");

            try
            {   
                string typedNamespace = String.Empty;
                string comments = string.Empty;
                string className = string.Empty;
                string code = string.Empty;

                #region Optionset Values
                string optionsetFile = $"{generatedFilesFolder}\\{filePrefix}.OptionSets.cs";
                if (File.Exists(optionsetFile))
                {
                    Console.WriteLine("Splitting Optionsets");
                    if (!Directory.Exists($"{outputFolder}\\OptionSets"))
                        Directory.CreateDirectory($"{outputFolder}\\OptionSets");

                    // Split Logical Name file
                    using (StreamReader sr = new StreamReader(optionsetFile))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("namespace"))
                            {
                                typedNamespace = line;
                            }

                            if (line.StartsWith("\t/// "))
                            {
                                comments += line + "\r\n";
                            }

                            if (line.StartsWith("\tpublic partial class "))
                            {
                                //Last word regex
                                Regex regex = new Regex(@"\s(\w+)$");
                                Match classNameMatch = regex.Match(line);

                                className = classNameMatch.Value.Trim();
                                code += $"\tpublic partial class {className}\r\n";
                            }
                            else if (!String.IsNullOrEmpty(className))
                            {
                                if (line.StartsWith("\t\t#region") || line.StartsWith("\t\t#endregion"))
                                {
                                    //Do nothing
                                }
                                else
                                {
                                    code += $"{line}\r\n";
                                }
                            }

                            //Class has closed - write the file
                            if (line.StartsWith("\t}") && !string.IsNullOrWhiteSpace(className))
                            {
                                code = code.Replace("\tstatic\r\n\t\tpublic class", "\t\tpublic static class");
                                File.WriteAllText($"{outputFolder}\\OptionSets\\{className}.cs", $"{typedNamespace}\r\n{{\r\n{comments}{code}}}\r\n");

                                code = string.Empty;
                                className = string.Empty;
                                comments = string.Empty;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"File not Found: {optionsetFile}");
                }
                #endregion

                #region Logical Names File
                string attributeFile = $"{generatedFilesFolder}\\{filePrefix}.Attributes.cs";
                if (File.Exists(attributeFile))
                {
                    if (!Directory.Exists($"{outputFolder}\\Attributes"))
                        Directory.CreateDirectory($"{outputFolder}\\Attributes");

                    // Split Logical Name file
                    using (StreamReader sr = new StreamReader(attributeFile))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("namespace"))
                            {
                                typedNamespace = line;
                            }

                            if (line.StartsWith("\t/// "))
                            {
                                comments += line + "\r\n";
                            }

                            if (line.StartsWith("\tpublic partial class "))
                            {
                                //Last word regex
                                Regex regex = new Regex(@"\s(\w+)$");
                                Match classNameMatch = regex.Match(line);

                                className = classNameMatch.Value.Trim();
                                code += $"\tpublic static class {className}\r\n";
                            }
                            else if (!String.IsNullOrEmpty(className))
                            {
                                code += $"{line}\r\n";
                            }

                            //Class has closed - write the file
                            if (line.StartsWith("\t}"))
                            {
                                File.WriteAllText($"{outputFolder}\\Attributes\\{className}.cs", $"{typedNamespace}\r\n{{\r\n{comments}{code}}}\r\n");

                                code = string.Empty;
                                className = string.Empty;
                                comments = string.Empty;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"File not Found: {attributeFile}");
                }
                #endregion

                #region Typed Entities File
                string entityFile = $"{generatedFilesFolder}\\{filePrefix}.Entities.cs";
                if (File.Exists(entityFile))
                {
                    if (!Directory.Exists($"{outputFolder}\\Entities"))
                        Directory.CreateDirectory($"{outputFolder}\\Entities");

                    bool processingCode = false;
                    using (StreamReader sr = new StreamReader(entityFile))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("namespace"))
                            {
                                typedNamespace = line;
                            }

                            if (line.StartsWith("\t[System.Runtime.Serialization.DataContractAttribute()]"))
                            {
                                processingCode = true;
                            }

                            if (line.StartsWith("\tpublic partial class "))
                            {
                                //Last word regex                       
                                Regex regex = new Regex(@"\bpublic partial class\s+\S+");
                                Match regexMatch = regex.Match(line);

                                string partialName = regexMatch.Value.Trim();
                                regex = new Regex(@"\s(\w+)$");
                                regexMatch = regex.Match(partialName);
                                className = regexMatch.Value.Trim();
                            }

                            if (processingCode)
                            {
                                code += $"{line}\r\n";
                            }

                            //Class has closed - write the file
                            if (line.StartsWith("\t}") && !String.IsNullOrWhiteSpace(className))
                            {
                                File.WriteAllText($"{outputFolder}\\Entities\\{className}.cs", $"{typedNamespace}\r\n{{{code}}}");

                                code = string.Empty;
                                className = string.Empty;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"File not Found: {entityFile}");
                }
                #endregion
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
