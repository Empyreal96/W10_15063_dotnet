// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimePickedEventArgs))]
  [WebHostHidden]
  [Guid(2329149217, 24422, 18309, 185, 153, 36, 254, 243, 159, 182, 219)]
  internal interface ITimePickedEventArgs
  {
    TimeSpan OldTime { get; }

    TimeSpan NewTime { get; }
  }
}
