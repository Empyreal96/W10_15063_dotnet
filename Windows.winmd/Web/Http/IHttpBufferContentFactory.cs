// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpBufferContentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3156263315, 50207, 20471, 145, 35, 100, 53, 115, 110, 173, 194)]
  [ExclusiveTo(typeof (HttpBufferContent))]
  internal interface IHttpBufferContentFactory
  {
    HttpBufferContent CreateFromBuffer(IBuffer content);

    HttpBufferContent CreateFromBufferWithOffset(
      IBuffer content,
      uint offset,
      uint count);
  }
}
