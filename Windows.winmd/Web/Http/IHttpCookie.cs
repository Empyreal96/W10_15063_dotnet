// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpCookie
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpCookie))]
  [Guid(525633762, 52269, 18297, 134, 167, 136, 241, 6, 135, 210, 73)]
  internal interface IHttpCookie
  {
    string Name { get; }

    string Domain { get; }

    string Path { get; }

    IReference<DateTime> Expires { get; set; }

    bool HttpOnly { get; set; }

    bool Secure { get; set; }

    string Value { get; set; }
  }
}
