// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPart
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferContentPart))]
  [Guid(3907081815, 55249, 20184, 131, 142, 103, 74, 194, 23, 172, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTransferContentPart
  {
    void SetHeader(string headerName, string headerValue);

    void SetText(string value);

    void SetFile(IStorageFile value);
  }
}
