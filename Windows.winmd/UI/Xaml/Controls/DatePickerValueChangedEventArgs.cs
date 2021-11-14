// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DatePickerValueChangedEventArgs : IDatePickerValueChangedEventArgs
  {
    public extern DateTime OldDate { [MethodImpl] get; }

    public extern DateTime NewDate { [MethodImpl] get; }
  }
}
