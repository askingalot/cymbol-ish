using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Cymbol
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0 || !File.Exists(args[0]))
            {
                Console.WriteLine("You did it wrong...Gimme a file!");
                Environment.Exit(1);
            }

            var input = File.ReadAllText(args[0]);
            var stream = CharStreams.fromstring(input);
            var lexer = new CymbolLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new CymbolParser(tokens);
            var interpreter = new CymbolInterpreter();

            interpreter.Visit(parser.program());
        }
    }
}
