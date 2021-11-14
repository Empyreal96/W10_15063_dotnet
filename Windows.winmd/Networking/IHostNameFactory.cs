// Decompiled with JetBrains decompiler
// Type: Windows.Networking.IHostNameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking
{
  [ExclusiveTo(typeof (HostName))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1166812141, 28975, 17782, 173, 241, 194, 11, 44, 100, 53, 88)]
  internal interface IHostNameFactory
  {
    HostName CreateHostName(string hostName);
  }
}
