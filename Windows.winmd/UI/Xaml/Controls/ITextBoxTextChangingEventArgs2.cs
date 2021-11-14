// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxTextChangingEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3228712260, 21414, 16735, 169, 129, 80, 223, 175, 27, 236, 190)]
  [ExclusiveTo(typeof (TextBoxTextChangingEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ITextBoxTextChangingEventArgs2
  {
    bool IsContentChanging { get; }
  }
}
