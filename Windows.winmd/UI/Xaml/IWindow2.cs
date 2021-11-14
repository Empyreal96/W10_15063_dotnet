// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindow2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (Window))]
  [Guid(3548673439, 13558, 17538, 132, 53, 245, 82, 249, 178, 76, 200)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWindow2
  {
    void SetTitleBar(UIElement value);
  }
}
