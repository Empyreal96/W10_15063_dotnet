// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.WebAccountProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Credentials
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWebAccountProviderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebAccountProvider : 
    IWebAccountProvider,
    IWebAccountProvider2,
    IWebAccountProvider3
  {
    [MethodImpl]
    public extern WebAccountProvider(string id, string displayName, Uri iconUri);

    public extern string Id { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern Uri IconUri { [Deprecated("IconUri may be altered or unavailable for releases after Windows 8.2. Instead, use Icon.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern string DisplayPurpose { [MethodImpl] get; }

    public extern string Authority { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }
  }
}
