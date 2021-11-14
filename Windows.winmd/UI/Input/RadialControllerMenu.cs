// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerMenu
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RadialControllerMenu : IRadialControllerMenu
  {
    public extern IVector<RadialControllerMenuItem> Items { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern RadialControllerMenuItem GetSelectedMenuItem();

    [MethodImpl]
    public extern void SelectMenuItem(RadialControllerMenuItem menuItem);

    [MethodImpl]
    public extern bool TrySelectPreviouslySelectedMenuItem();
  }
}
