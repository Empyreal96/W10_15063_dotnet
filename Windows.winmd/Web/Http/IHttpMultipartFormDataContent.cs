// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartFormDataContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpMultipartFormDataContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1691564002, 59751, 17956, 182, 209, 207, 116, 96, 74, 74, 66)]
  internal interface IHttpMultipartFormDataContent : IIterable<IHttpContent>
  {
    [Overload("Add")]
    void Add(IHttpContent content);

    [Overload("AddWithName")]
    void Add(IHttpContent content, string name);

    [Overload("AddWithNameAndFileName")]
    void Add(IHttpContent content, string name, string fileName);
  }
}
