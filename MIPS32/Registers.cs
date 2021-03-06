﻿using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace MIPS32
{
    class Registers
    {
        public static Dictionary<string, RegisterType> Collections = new Dictionary<string, RegisterType>();
        public static void LoadRegisters()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("MIPS32.registers.txt"))
            using (StreamReader inFile = new StreamReader(stream))
            {
                while (!inFile.EndOfStream)
                {
                    string line = inFile.ReadLine();
                    string[] line_el = line.Split(' ');
                    Collections.Add(line_el[0], new RegisterType(line_el[1]));
                }
            }
            
        }
    }
}
