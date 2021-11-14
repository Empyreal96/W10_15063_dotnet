// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextControlPasteEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextControlPasteEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1272043045, 8730, 18302, 187, 44, 173, 12, 30, 209, 37, 231)]
  [WebHostHidden]
  internal interface ITextControlPasteEventArgs
  {
    bool Handled { get; set; }
  }
}
