// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerValueChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePickerValueChangedEventArgs))]
  [Guid(451305906, 45492, 17011, 150, 224, 25, 218, 255, 24, 116, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDatePickerValueChangedEventArgs
  {
    DateTime OldDate { get; }

    DateTime NewDate { get; }
  }
}
