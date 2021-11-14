// Decompiled with JetBrains decompiler
// Type: Windows.System.AppDiagnosticInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IAppDiagnosticInfoStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppDiagnosticInfo : IAppDiagnosticInfo
  {
    public extern AppInfo AppInfo { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<AppDiagnosticInfo>> RequestInfoAsync();
  }
}
