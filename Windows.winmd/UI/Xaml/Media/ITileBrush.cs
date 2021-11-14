// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITileBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TileBrush))]
  [WebHostHidden]
  [Guid(3254898438, 52612, 18597, 150, 7, 102, 77, 115, 97, 205, 97)]
  internal interface ITileBrush
  {
    AlignmentX AlignmentX { get; set; }

    AlignmentY AlignmentY { get; set; }

    Stretch Stretch { get; set; }
  }
}
