using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sada.Tools.Windows.AppSettings
{
    internal class AppSettingsModel
    {
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
        public JWT Jwt { get; set; }
    }

    internal class JWT
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }

    internal class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    internal class LogLevel
    {
        public string Default { get; set; }
        [JsonPropertyName("Microsoft.AspNetCore")]
        public string MicrosoftAspNetCore { get; set; }
    }
}
