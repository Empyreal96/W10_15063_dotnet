// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IResponseInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResponseInformation))]
  [Guid(4173044242, 63251, 18322, 139, 104, 217, 210, 151, 249, 29, 46)]
  internal interface IResponseInformation
  {
    bool IsResumable { get; }

    Uri ActualUri { get; }

    uint StatusCode { get; }

    IMapView<string, string> Headers { get; }
  }
}
