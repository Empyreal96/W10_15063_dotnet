// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IBackgroundTransferContentPartFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BackgroundTransferContentPart : IBackgroundTransferContentPart
  {
    [MethodImpl]
    public extern BackgroundTransferContentPart(string name);

    [MethodImpl]
    public extern BackgroundTransferContentPart(string name, string fileName);

    [MethodImpl]
    public extern BackgroundTransferContentPart();

    [MethodImpl]
    public extern void SetHeader(string headerName, string headerValue);

    [MethodImpl]
    public extern void SetText(string value);

    [MethodImpl]
    public extern void SetFile(IStorageFile value);
  }
}
