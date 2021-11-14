// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISectionsInViewChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3712609899, 53605, 17167, 163, 125, 184, 7, 6, 79, 133, 225)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SectionsInViewChangedEventArgs))]
  internal interface ISectionsInViewChangedEventArgs
  {
    IVector<HubSection> AddedSections { get; }

    IVector<HubSection> RemovedSections { get; }
  }
}
