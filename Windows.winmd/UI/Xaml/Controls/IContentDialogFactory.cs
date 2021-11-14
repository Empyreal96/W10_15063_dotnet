// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContentDialog))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(89485688, 40334, 17173, 179, 125, 104, 12, 20, 1, 44, 53)]
  [WebHostHidden]
  internal interface IContentDialogFactory
  {
    ContentDialog CreateInstance(object outer, out object inner);
  }
}
