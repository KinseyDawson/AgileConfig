using System.Collections.Generic;

namespace AgileConfig.Server.Apisite.Models
{
    public class AppAuthVM: IAppIdModel
    {
        public List<string> EditConfigPermissionUsers { get; set; }

        public List<string> PublishConfigPermissionUsers { get; set; }

        public string AppId { get; set; }
    }
}
