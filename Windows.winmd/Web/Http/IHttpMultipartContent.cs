// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpMultipartContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3750849279, 39206, 19145, 170, 241, 224, 208, 78, 240, 155, 185)]
  internal interface IHttpMultipartContent : IIterable<IHttpContent>
  {
    void Add(IHttpContent content);
  }
}
