// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextCompositionStartedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextCompositionStartedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(661329577, 25831, 19120, 188, 75, 160, 45, 115, 131, 91, 251)]
  internal interface ICoreTextCompositionStartedEventArgs
  {
    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
