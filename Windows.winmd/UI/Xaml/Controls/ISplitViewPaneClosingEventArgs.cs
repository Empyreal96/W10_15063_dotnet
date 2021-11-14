// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitViewPaneClosingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2479835470, 31381, 17624, 149, 98, 27, 52, 130, 72, 218, 159)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SplitViewPaneClosingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISplitViewPaneClosingEventArgs
  {
    bool Cancel { get; set; }
  }
}
