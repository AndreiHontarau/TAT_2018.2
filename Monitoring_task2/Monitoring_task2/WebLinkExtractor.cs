using System;
using System.Text.RegularExpressions;

namespace Monitoring_task2
{
    /// <summary>
    /// Class to extract and validate web link from string
    /// </summary>
    public static class WebLinkExtractor
    {
        private static string urlPattern = @"https?://[\w].[\w]";

        public static string ExtractLink(string text)
        {
            Match link = Regex.Match(text, urlPattern);

            return link.Value;
        }

        /// <summary>
        /// Validates an http or https link
        /// </summary>
        /// <param name="link">Link to validate</param>
        /// <returns>True if link is valid, false otherwise</returns>
        public static bool Validate(string link)
        {
            Uri url;

            return (Uri.TryCreate(link, UriKind.RelativeOrAbsolute, out url) &&
                    (url.Scheme == Uri.UriSchemeHttp || url.Scheme == Uri.UriSchemeHttps));
        }
    }
}
