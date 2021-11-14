// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TextBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1896759928, 34089, 18387, 141, 142, 48, 126, 52, 207, 240, 129)]
  internal interface ITextBoxFactory
  {
    TextBox CreateInstance(object outer, out object inner);
  }
}
