// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePickerFlyoutItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDatePickerFlyoutItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DatePickerFlyoutItem : 
    DependencyObject,
    IDatePickerFlyoutItem,
    ICustomPropertyProvider
  {
    public extern string PrimaryText { [MethodImpl] get; [MethodImpl] set; }

    public extern string SecondaryText { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern ICustomProperty GetCustomProperty(string name);

    [MethodImpl]
    public extern ICustomProperty GetIndexedProperty(string name, TypeName type);

    [MethodImpl]
    public extern string GetStringRepresentation();

    public extern TypeName Type { [MethodImpl] get; }

    public static extern DependencyProperty PrimaryTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty SecondaryTextProperty { [MethodImpl] get; }
  }
}
