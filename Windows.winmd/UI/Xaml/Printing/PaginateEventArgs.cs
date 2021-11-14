// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.PaginateEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class PaginateEventArgs : IPaginateEventArgs
  {
    [MethodImpl]
    public extern PaginateEventArgs();

    public extern PrintTaskOptions PrintTaskOptions { [MethodImpl] get; }

    public extern int CurrentPreviewPageNumber { [MethodImpl] get; }
  }
}
