// Guids.cs
// MUST match guids.h
using System;

namespace Maxzhang.IDEBackground
{
    static class GuidList
    {
        public const string guidIDE_BackgroundPkgString = "0bbe7c71-dde7-4b38-b0aa-1ea41d263e9b";
        public const string guidIDE_BackgroundCmdSetString = "b7fb8f6f-d4c0-49f2-965b-b4cb3b7c6099";

        public static readonly Guid guidIDE_BackgroundCmdSet = new Guid(guidIDE_BackgroundCmdSetString);
    };
}