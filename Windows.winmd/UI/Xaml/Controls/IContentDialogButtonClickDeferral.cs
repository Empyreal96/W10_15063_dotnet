// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogButtonClickDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3171759671, 6606, 18758, 142, 119, 189, 3, 254, 142, 190, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentDialogButtonClickDeferral))]
  internal interface IContentDialogButtonClickDeferral
  {
    void Complete();
  }
}
