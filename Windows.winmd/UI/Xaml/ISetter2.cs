// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISetter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (Setter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1880528225, 1457, 20387, 157, 83, 142, 12, 140, 116, 122, 252)]
  [WebHostHidden]
  internal interface ISetter2
  {
    TargetPropertyPath Target { get; set; }
  }
}
