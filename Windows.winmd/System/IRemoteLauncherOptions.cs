// Decompiled with JetBrains decompiler
// Type: Windows.System.IRemoteLauncherOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RemoteLauncherOptions))]
  [Guid(2654611336, 10385, 19679, 162, 214, 157, 255, 125, 2, 230, 147)]
  internal interface IRemoteLauncherOptions
  {
    Uri FallbackUri { get; set; }

    IVector<string> PreferredAppIds { get; }
  }
}
