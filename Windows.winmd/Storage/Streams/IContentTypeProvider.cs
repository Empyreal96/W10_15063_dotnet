// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IContentTypeProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(2547030181, 15257, 19945, 136, 165, 225, 29, 47, 80, 199, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IContentTypeProvider
  {
    string ContentType { get; }
  }
}
