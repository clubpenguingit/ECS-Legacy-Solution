﻿using System;

namespace ECS.Refactored
{
    public class Writer : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}