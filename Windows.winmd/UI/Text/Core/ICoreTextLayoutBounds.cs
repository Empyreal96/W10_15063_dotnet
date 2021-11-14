// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextLayoutBounds
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreTextLayoutBounds))]
  [Guid(3916614004, 17462, 18711, 128, 208, 165, 37, 228, 202, 103, 128)]
  internal interface ICoreTextLayoutBounds
  {
    Rect TextBounds { get; set; }

    Rect ControlBounds { get; set; }
  }
}
