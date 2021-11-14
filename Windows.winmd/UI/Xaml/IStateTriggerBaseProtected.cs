// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStateTriggerBaseProtected
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1010950739, 36116, 16918, 153, 76, 249, 147, 4, 41, 246, 229)]
  [ExclusiveTo(typeof (StateTriggerBase))]
  internal interface IStateTriggerBaseProtected
  {
    void SetActive(bool IsActive);
  }
}
