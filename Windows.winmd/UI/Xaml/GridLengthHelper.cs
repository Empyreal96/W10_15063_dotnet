// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.GridLengthHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGridLengthHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GridLengthHelper : IGridLengthHelper
  {
    public static extern GridLength Auto { [MethodImpl] get; }

    [MethodImpl]
    public static extern GridLength FromPixels(double pixels);

    [MethodImpl]
    public static extern GridLength FromValueAndType(double value, GridUnitType type);

    [MethodImpl]
    public static extern bool GetIsAbsolute(GridLength target);

    [MethodImpl]
    public static extern bool GetIsAuto(GridLength target);

    [MethodImpl]
    public static extern bool GetIsStar(GridLength target);

    [MethodImpl]
    public static extern bool Equals(GridLength target, GridLength value);
  }
}
