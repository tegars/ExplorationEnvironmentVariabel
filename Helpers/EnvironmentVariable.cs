using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnEnvironmentVariabel.Helpers
{
    public static class EnvironmentVariable
    {
        public static bool IsChallenge(IConfiguration configuration)
        {
            return configuration.GetValue<bool>($"isChallenge");
        }
        public static string Freshdesk(IConfiguration configuration, string key)
        {
            string value = configuration.GetValue<string>($"freshdesk:{key}");
            if (string.IsNullOrEmpty(value))
                return "";
            return value;
        }
    }
}
