// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICandidateWindowBoundsChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2324980824, 33712, 19506, 148, 80, 81, 105, 165, 131, 139, 85)]
  [ExclusiveTo(typeof (CandidateWindowBoundsChangedEventArgs))]
  [WebHostHidden]
  internal interface ICandidateWindowBoundsChangedEventArgs
  {
    Rect Bounds { get; }
  }
}
