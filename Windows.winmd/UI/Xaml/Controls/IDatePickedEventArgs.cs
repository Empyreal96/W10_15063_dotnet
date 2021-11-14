// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2706537234, 22977, 17697, 178, 140, 177, 118, 103, 94, 124, 90)]
  [ExclusiveTo(typeof (DatePickedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePickedEventArgs
  {
    DateTime OldDate { get; }

    DateTime NewDate { get; }
  }
}
