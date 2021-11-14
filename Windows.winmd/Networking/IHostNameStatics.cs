// Decompiled with JetBrains decompiler
// Type: Windows.Networking.IHostNameStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking
{
  [ExclusiveTo(typeof (HostName))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4136424639, 41864, 20107, 145, 234, 84, 221, 109, 217, 1, 192)]
  internal interface IHostNameStatics
  {
    int Compare(string value1, string value2);
  }
}
