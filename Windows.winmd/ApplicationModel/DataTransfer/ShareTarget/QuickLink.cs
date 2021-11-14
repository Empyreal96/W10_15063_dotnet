// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.QuickLink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class QuickLink : IQuickLink
  {
    [MethodImpl]
    public extern QuickLink();

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> SupportedDataFormats { [MethodImpl] get; }

    public extern IVector<string> SupportedFileTypes { [MethodImpl] get; }
  }
}
