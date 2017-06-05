using Box.V2.Config;
using Box.V2.JWTAuth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getToken
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxConfigJSON oCfg = JsonConvert.DeserializeObject<BoxConfigJSON>(File.ReadAllText("box_app_config.json"));
            var boxConfig = new BoxConfig(oCfg.boxAppSettings.clientID, oCfg.boxAppSettings.clientSecret, oCfg.enterpriseID, oCfg.boxAppSettings.appAuth.privateKey, oCfg.boxAppSettings.appAuth.passphrase, oCfg.boxAppSettings.appAuth.publicKeyID);
            var boxJWT = new BoxJWTAuth(boxConfig);
            var adminToken = boxJWT.AdminToken(); //valid for 60 minutes so should be cached and re-used  
            File.WriteAllText("boxtoken.txt", adminToken);
        }
    }
}
