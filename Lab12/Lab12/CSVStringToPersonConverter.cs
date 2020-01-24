using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    public class CSVStringToPersonConverter
    {
        static public Person Convert(string csvString)
        {
            string[] lineData = csvString.Split(',');
            return new Person(
                System.Convert.ToInt32(lineData[0]),
                lineData[1],
                lineData[2],
                lineData[3]);
        }
    }
}
