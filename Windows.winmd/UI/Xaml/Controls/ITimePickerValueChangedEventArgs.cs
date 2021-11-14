// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerValueChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TimePickerValueChangedEventArgs))]
  [WebHostHidden]
  [Guid(793697165, 47509, 20017, 139, 169, 196, 220, 222, 178, 28, 163)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimePickerValueChangedEventArgs
  {
    TimeSpan OldTime { get; }

    TimeSpan NewTime { get; }
  }
}
