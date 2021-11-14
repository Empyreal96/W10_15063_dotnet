// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitViewFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4043405114, 2126, 20409, 132, 66, 99, 34, 27, 68, 83, 63)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplitView))]
  internal interface ISplitViewFactory
  {
    SplitView CreateInstance(object outer, out object inner);
  }
}
