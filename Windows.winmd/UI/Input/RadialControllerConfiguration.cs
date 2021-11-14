// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Static(typeof (IRadialControllerConfigurationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  public sealed class RadialControllerConfiguration : 
    IRadialControllerConfiguration,
    IRadialControllerConfiguration2
  {
    [MethodImpl]
    public extern void SetDefaultMenuItems(
      IIterable<RadialControllerSystemMenuItemKind> buttons);

    [MethodImpl]
    public extern void ResetToDefaultMenuItems();

    [MethodImpl]
    public extern bool TrySelectDefaultMenuItem(RadialControllerSystemMenuItemKind type);

    public extern RadialController ActiveControllerWhenMenuIsSuppressed { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsMenuSuppressed { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public static extern RadialControllerConfiguration GetForCurrentView();
  }
}
