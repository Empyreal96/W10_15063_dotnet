// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ICellularApnContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (CellularApnContext))]
  [Guid(1873095156, 61437, 17730, 154, 178, 112, 91, 191, 148, 148, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICellularApnContext
  {
    string ProviderId { get; set; }

    string AccessPointName { get; set; }

    string UserName { get; set; }

    string Password { get; set; }

    bool IsCompressionEnabled { get; set; }

    CellularApnAuthenticationType AuthenticationType { get; set; }
  }
}
