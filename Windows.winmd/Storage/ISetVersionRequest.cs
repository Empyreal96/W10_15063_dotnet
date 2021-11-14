// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISetVersionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(3116854171, 4182, 20073, 131, 48, 22, 38, 25, 149, 111, 155)]
  [ExclusiveTo(typeof (SetVersionRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISetVersionRequest
  {
    uint CurrentVersion { get; }

    uint DesiredVersion { get; }

    SetVersionDeferral GetDeferral();
  }
}
