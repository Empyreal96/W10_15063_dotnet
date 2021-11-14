// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IProgressBarFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3667561489, 5521, 16395, 169, 147, 15, 28, 92, 193, 47, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ProgressBar))]
  internal interface IProgressBarFactory
  {
    ProgressBar CreateInstance(object outer, out object inner);
  }
}
