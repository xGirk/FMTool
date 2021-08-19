using FMTool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FMTool
{
    public static class FMTool
    {
        /// <summary>
        /// Given a list of type <typeparamref name="T"/> returns a random element from it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>A random <typeparamref name="T"/>.</returns>
        public static T GetRandom<T>(List<T> list)
        {
            var roll = new Random().Next(list.Count);
            return list[roll];
        }
    }
}