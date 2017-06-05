using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getToken
{
    public class AppAuth
    {
        public string publicKeyID { get; set; }
        public string privateKey { get; set; }
        public string passphrase { get; set; }
    }

    public class BoxAppSettings
    {
        public string clientID { get; set; }
        public string clientSecret { get; set; }
        public AppAuth appAuth { get; set; }
    }

    public class BoxConfigJSON
    {
        public BoxAppSettings boxAppSettings { get; set; }
        public string enterpriseID { get; set; }
    }
}
