// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProviderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(494304753, 57825, 19354, 167, 116, 92, 124, 126, 59, 243, 113)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountProvider))]
  internal interface IWebAccountProviderFactory
  {
    WebAccountProvider CreateWebAccountProvider(
      string id,
      string displayName,
      Uri iconUri);
  }
}
