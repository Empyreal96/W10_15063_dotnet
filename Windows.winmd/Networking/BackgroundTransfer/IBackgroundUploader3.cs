// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploader3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(3109983289, 23536, 19258, 140, 71, 44, 97, 153, 168, 84, 185)]
  [ExclusiveTo(typeof (BackgroundUploader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundUploader3
  {
    BackgroundTransferCompletionGroup CompletionGroup { get; }
  }
}
