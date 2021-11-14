// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlTemplate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ControlTemplate))]
  [Guid(4023533966, 16864, 18619, 139, 130, 145, 237, 161, 186, 63, 226)]
  [WebHostHidden]
  internal interface IControlTemplate
  {
    TypeName TargetType { get; set; }
  }
}
