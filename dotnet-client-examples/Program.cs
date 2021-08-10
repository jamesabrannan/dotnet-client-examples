﻿using System;
using DynamicPDF.Api;

namespace DynamicPdfCloudApiClientExamples
{
   

    // NEVER INCLUDE YOUR KEY VALUE IN A GITHUB REPOSITORY.
    // Assumes the base url of api.dynamicpdf.com

    class Program
    {
        // first argument is the API Key

        static void Main(string[] args)
        {
            PdfInfoExample.PdfInfoExampleOne(args[0]);
            PrintDivider();
            ImageInfoExample.ImageInfoExampleOne(args[0]);
            PrintDivider();
            ImageInfoExample.ImageInfoExampleTwo(args[0]);
            PrintDivider();
            PdfTextExample.PdfInfoExampleOne(args[0]);
            PrintDivider();
            PdfXmpExample.PdfXmpExampleOne(args[0]);
            PdfExample.PdfExampleOne(args[0]);
        }

        static void PrintDivider()
        {
            Console.WriteLine("============================================");
        }
    }
}
