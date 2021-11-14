// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPaginateEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PaginateEventArgs))]
  [Guid(3985924054, 31147, 17079, 147, 10, 61, 110, 9, 1, 29, 33)]
  [WebHostHidden]
  internal interface IPaginateEventArgs
  {
    PrintTaskOptions PrintTaskOptions { get; }

    int CurrentPreviewPageNumber { get; }
  }
}
