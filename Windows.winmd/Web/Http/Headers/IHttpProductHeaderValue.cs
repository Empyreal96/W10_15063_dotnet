// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpProductHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4110347779, 60372, 16736, 185, 255, 128, 124, 81, 131, 182, 230)]
  internal interface IHttpProductHeaderValue
  {
    string Name { get; }

    string Version { get; }
  }
}
