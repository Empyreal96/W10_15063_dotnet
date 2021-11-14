// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPathIconFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (PathIcon))]
  [WebHostHidden]
  [Guid(2946340434, 40029, 18999, 158, 26, 4, 74, 190, 239, 121, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPathIconFactory
  {
    PathIcon CreateInstance(object outer, out object inner);
  }
}
