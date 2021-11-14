// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlBinaryWriterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Markup
{
  [ExclusiveTo(typeof (XamlBinaryWriter))]
  [Guid(227463290, 39810, 19112, 182, 139, 2, 111, 45, 225, 204, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IXamlBinaryWriterStatics
  {
    XamlBinaryWriterErrorInformation Write(
      IVector<IRandomAccessStream> inputStreams,
      IVector<IRandomAccessStream> outputStreams,
      IXamlMetadataProvider xamlMetadataProvider);
  }
}
