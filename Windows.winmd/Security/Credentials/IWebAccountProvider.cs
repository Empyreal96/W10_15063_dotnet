// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(702335171, 31417, 19068, 163, 54, 185, 66, 249, 219, 247, 199)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountProvider))]
  internal interface IWebAccountProvider
  {
    string Id { get; }

    string DisplayName { get; }

    Uri IconUri { [Deprecated("IconUri may be altered or unavailable for releases after Windows 8.2. Instead, use Icon.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
