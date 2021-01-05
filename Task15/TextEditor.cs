using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task15
{
    class TextEditor
    {
        /// <summary>
        /// concat two strings
        /// </summary>
        /// <param name="source"></param>
        /// <param name="toAppend"></param>
        /// <returns>source + toAppend</returns>
        static string AppendString(string source, string toAppend) => source + toAppend;

        /// <summary>
        /// removed all chars from string
        /// </summary>
        /// <param name="source">source text</param>
        /// <param name="symbolToDelete">some symbol</param>
        /// <returns>source string without symbolToDelete</returns>
        static string DeleteChars(string source, char symbolToDelete)
        {
            return new StringBuilder(source).Replace(source, string.Empty).ToString();
        }

        /// <summary>
        /// Replace oldWord from text to newWord
        /// </summary>
        /// <param name="text"></param>
        /// <param name="oldWord"></param>
        /// <param name="newWord"></param>
        /// <returns></returns>
        private static string ReplaceTheWord(string text, string oldWord, string newWord)
        {
            return new StringBuilder(text).Replace(oldWord, newWord).ToString();
        }
    }
}
