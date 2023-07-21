using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    // Employee class with a generic type parameter
    public class Employee<T>
    {
        // Property to hold a list of generic type "T"
        public List<T> Things { get; set; }
    }
}
