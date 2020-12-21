using System.Collections.Generic;
using HCGStudio.SystemRefresher.Core.Software;

namespace HCGStudio.SystemRefresher.Core.Scanner
{
    public interface ISoftwareScanner
    {
        List<SoftwareRestore> ScanSoftware();
    }
}