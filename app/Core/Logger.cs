﻿using System;

namespace app.Core
{
    class Logger
    {
        public static void Write(string s)
        {
            Console.WriteLine($"[{DateTime.UtcNow.ToString()}] {s}");
        }
    }
}