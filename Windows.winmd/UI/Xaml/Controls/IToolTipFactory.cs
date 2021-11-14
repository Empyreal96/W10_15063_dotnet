// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToolTipFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ToolTip))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2307101699, 46392, 18915, 164, 48, 58, 192, 55, 220, 111, 224)]
  [WebHostHidden]
  internal interface IToolTipFactory
  {
    ToolTip CreateInstance(object outer, out object inner);
  }
}
