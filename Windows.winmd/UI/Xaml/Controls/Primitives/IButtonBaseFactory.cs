// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IButtonBaseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ButtonBase))]
  [Guid(949714033, 21024, 17074, 153, 146, 38, 144, 193, 166, 112, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IButtonBaseFactory
  {
    ButtonBase CreateInstance(object outer, out object inner);
  }
}
