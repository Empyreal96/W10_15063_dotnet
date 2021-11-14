// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4005808772, 39062, 19069, 187, 53, 111, 178, 30, 174, 202, 17)]
  [ExclusiveTo(typeof (DatePicker))]
  [WebHostHidden]
  internal interface IDatePickerFactory
  {
    DatePicker CreateInstance(object outer, out object inner);
  }
}
