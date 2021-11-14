// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICanvasFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(456297425, 46080, 19086, 148, 59, 90, 210, 196, 91, 224, 223)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Canvas))]
  internal interface ICanvasFactory
  {
    Canvas CreateInstance(object outer, out object inner);
  }
}
