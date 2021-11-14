// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBackClickEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(719721580, 18302, 18633, 136, 48, 44, 70, 75, 124, 113, 4)]
  [ExclusiveTo(typeof (BackClickEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IBackClickEventArgs
  {
    bool Handled { get; set; }
  }
}
