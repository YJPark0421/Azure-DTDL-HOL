﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Excel2DTDL
{
    public static class Log
    {
        static public void Out(string s, ConsoleColor col = ConsoleColor.White)
        {
            Console.ForegroundColor = col;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static public void Error(string s)
        {
            Out(s, ConsoleColor.DarkRed);
        }

        static public void Alert(string s)
        {
            Out(s, ConsoleColor.DarkYellow);
        }

        static public void Ok(string s)
        {
            Out(s, ConsoleColor.DarkGreen);
        }

    }
}
