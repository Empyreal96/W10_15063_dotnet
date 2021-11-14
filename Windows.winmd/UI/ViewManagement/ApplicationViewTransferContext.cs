// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewTransferContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewTransferContextStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class ApplicationViewTransferContext : IApplicationViewTransferContext
  {
    [MethodImpl]
    public extern ApplicationViewTransferContext();

    public extern int ViewId { [MethodImpl] get; [MethodImpl] set; }

    public static extern string DataPackageFormatId { [MethodImpl] get; }
  }
}
