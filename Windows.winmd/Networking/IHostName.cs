// Decompiled with JetBrains decompiler
// Type: Windows.Networking.IHostName
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HostName))]
  [Guid(3213806253, 60822, 18855, 144, 132, 212, 22, 202, 232, 141, 203)]
  internal interface IHostName
  {
    IPInformation IPInformation { get; }

    string RawName { get; }

    string DisplayName { get; }

    string CanonicalName { get; }

    HostNameType Type { get; }

    bool IsEqual(HostName hostName);
  }
}
