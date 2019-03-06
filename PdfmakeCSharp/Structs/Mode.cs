﻿using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public struct Mode
    {
        public const string Numeric = "numeric";
        public const string AlphaNumeric = "alphanumeric";
        public const string Octet = "octet";
    }
}
