﻿using System;
using System.Collections.Generic;

namespace StreamHunter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hunter hunter = new Hunter("C:/Users/Onur/Google Drive/workspace/NET/TiviBackend/playlist.tivi");
            hunter.Schedule();
        }
    }
}