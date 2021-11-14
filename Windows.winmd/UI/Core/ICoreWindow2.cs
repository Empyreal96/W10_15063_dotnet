// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreWindow))]
  [Guid(2083199877, 26903, 17249, 156, 2, 13, 158, 58, 66, 11, 149)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreWindow2
  {
    Point PointerPosition { set; }
  }
}
