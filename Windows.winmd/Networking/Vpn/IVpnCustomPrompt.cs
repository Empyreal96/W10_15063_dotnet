// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPrompt
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2603531899, 34773, 17212, 180, 246, 238, 230, 170, 104, 162, 68)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnCustomPrompt
  {
    string Label { set; get; }

    bool Compulsory { set; get; }

    bool Bordered { set; get; }
  }
}
