﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Threading.Tasks;

namespace Aqua.Console
{
    public class Program
    {
        private static readonly TraceSource Log = new TraceSource("Aqua.Console");

        public static void Main(string[] args)
        {
            // Deal with command-line arguments to find out what we need to do.
            if (args == null || args.Count() == 0)
            {
                Log.TraceEvent(TraceEventType.Verbose, 0, "Printing help due to bad command line arguments.");
                PrintHelp();
                return;
            }
            
            switch(args[0])
            {
                case "help":
                case "version":
                    Log.TraceEvent(TraceEventType.Verbose, 0, "Printing help message due to request from command line.");
                    PrintHelp();
                    break;

                case "run":
                case "debug":
                case "assemble":
                case "disassemble":
                case "compile":
                    Log.TraceEvent(TraceEventType.Critical, 0, "These commands not implemented yet.");
                    throw new NotImplementedException("These commands not implemented yet.");

                default:
                    Log.TraceEvent(TraceEventType.Verbose, 0, "Printing help due to bad command line arguments.");
                    PrintHelp();
                    break;
            }

            
            
            Thread.Sleep(3000);
        }

        public static void PrintHelp()
        {
            System.Console.Out.WriteLine("Aqua Console - version " + typeof(Program).Assembly.GetName().Version);
            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("aqua help");
            System.Console.Out.WriteLine("aqua version");
            System.Console.Out.WriteLine("\tShows this version and help information.");
            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("aqua run foo.abc");
            System.Console.Out.WriteLine("\tExecutes the aqua bytecode in the foo.abc file.");
            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("aqua debug foo.abc");
            System.Console.Out.WriteLine("\tExecutes the aqua bytecode in the foo.abc file using the debugger.");
            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("aqua assemble foo.aqua foo.abc");
            System.Console.Out.WriteLine("\tAssembles the aqua assembly file foo.aqua, output going to foo.abc.");
            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("aqua disassemble foo.abc foo.aqua");
            System.Console.Out.WriteLine("\tDisassembles the aqua assembly file foo.abc, output going to foo.aqua.");
            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("aqua compile foo.c foo.abc");
            System.Console.Out.WriteLine("\tCompiles the C-language source foo.c into Aqua bytecode file foo.abc.");
        }
    }
}
