// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.AccessKeyManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Static(typeof (IAccessKeyManagerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAccessKeyManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AccessKeyManager : IAccessKeyManager
  {
    public static extern bool AreKeyTipsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public static extern bool IsDisplayModeEnabled { [MethodImpl] get; }

    public static extern event TypedEventHandler<object, object> IsDisplayModeEnabledChanged;

    [MethodImpl]
    public static extern void ExitDisplayMode();
  }
}
