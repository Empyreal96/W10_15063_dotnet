// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IRun
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Run))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1498758275, 3604, 18877, 184, 75, 197, 38, 243, 3, 67, 73)]
  internal interface IRun
  {
    string Text { get; set; }

    FlowDirection FlowDirection { get; set; }
  }
}
