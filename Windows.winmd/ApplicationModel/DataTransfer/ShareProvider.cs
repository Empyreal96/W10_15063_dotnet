// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IShareProviderFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ShareProvider : IShareProvider
  {
    [MethodImpl]
    public extern ShareProvider(
      string title,
      RandomAccessStreamReference displayIcon,
      Color backgroundColor,
      ShareProviderHandler handler);

    public extern string Title { [MethodImpl] get; }

    public extern RandomAccessStreamReference DisplayIcon { [MethodImpl] get; }

    public extern Color BackgroundColor { [MethodImpl] get; }

    public extern object Tag { [MethodImpl] get; [MethodImpl] set; }
  }
}
