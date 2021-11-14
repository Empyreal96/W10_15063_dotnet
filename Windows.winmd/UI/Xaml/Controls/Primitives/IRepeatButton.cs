// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRepeatButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (RepeatButton))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(35655161, 538, 18506, 169, 59, 15, 49, 2, 3, 20, 229)]
  internal interface IRepeatButton
  {
    int Delay { get; set; }

    int Interval { get; set; }
  }
}
