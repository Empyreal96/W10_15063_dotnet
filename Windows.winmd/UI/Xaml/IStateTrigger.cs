// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStateTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (StateTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1739452206, 55513, 18935, 161, 253, 46, 53, 238, 221, 35, 205)]
  [WebHostHidden]
  internal interface IStateTrigger
  {
    bool IsActive { get; set; }
  }
}
