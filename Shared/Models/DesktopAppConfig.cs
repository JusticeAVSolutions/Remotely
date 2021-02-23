using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotely.Shared.Models
{
    public class DesktopAppConfig
    {
        private string _host = "http://remotely.javs.com";

        public string Host
        {
            get => _host;
            set
            {
                _host = value?.TrimEnd('/');
            }
        }
        public string OrganizationId { get; set; } = "79393411-26a5-4b36-9e64-83fc7b48b101";
    }
}
