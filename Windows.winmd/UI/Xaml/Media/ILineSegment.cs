// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILineSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LineSegment))]
  [Guid(4016713253, 16368, 17440, 164, 17, 113, 130, 164, 206, 203, 21)]
  internal interface ILineSegment
  {
    Point Point { get; set; }
  }
}
