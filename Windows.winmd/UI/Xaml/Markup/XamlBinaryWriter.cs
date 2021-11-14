// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XamlBinaryWriter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Markup
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IXamlBinaryWriterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class XamlBinaryWriter : IXamlBinaryWriter
  {
    [MethodImpl]
    public static extern XamlBinaryWriterErrorInformation Write(
      IVector<IRandomAccessStream> inputStreams,
      IVector<IRandomAccessStream> outputStreams,
      IXamlMetadataProvider xamlMetadataProvider);
  }
}
