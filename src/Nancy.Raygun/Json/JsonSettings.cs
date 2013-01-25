using System.Collections.Generic;
using Nancy.Raygun.Json.Converters;

namespace Nancy.Raygun.Json
{
    /// <summary>
    ///     Json serializer settings
    /// </summary>
    public static class JsonSettings
    {
        static JsonSettings()
        {
            MaxJsonLength = 102400;
            MaxRecursions = 100;
            Converters = new List<JavaScriptConverter>
            {
                new TimeSpanConverter(),
            };
        }

        /// <summary>
        ///     Max length of json output
        /// </summary>
        public static int MaxJsonLength { get; set; }

        /// <summary>
        ///     Maximum number of recursions
        /// </summary>
        public static int MaxRecursions { get; set; }

        public static IList<JavaScriptConverter> Converters { get; set; }
    }
}