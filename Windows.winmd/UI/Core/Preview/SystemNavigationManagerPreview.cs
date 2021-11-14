// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.SystemNavigationManagerPreview
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (ISystemNavigationManagerPreviewStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class SystemNavigationManagerPreview : ISystemNavigationManagerPreview
  {
    public extern event EventHandler<SystemNavigationCloseRequestedPreviewEventArgs> CloseRequested;

    [MethodImpl]
    public static extern SystemNavigationManagerPreview GetForCurrentView();
  }
}
