// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualState2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisualState))]
  [WebHostHidden]
  [Guid(262207638, 25792, 17915, 141, 36, 251, 131, 41, 140, 13, 147)]
  internal interface IVisualState2
  {
    SetterBaseCollection Setters { get; }

    IVector<StateTriggerBase> StateTriggers { get; }
  }
}
