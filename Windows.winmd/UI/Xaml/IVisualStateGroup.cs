// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (VisualStateGroup))]
  [WebHostHidden]
  [Guid(3841579428, 57384, 17630, 155, 21, 73, 41, 174, 10, 38, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVisualStateGroup
  {
    string Name { get; }

    IVector<VisualTransition> Transitions { get; }

    IVector<VisualState> States { get; }

    VisualState CurrentState { get; }

    event VisualStateChangedEventHandler CurrentStateChanged;

    event VisualStateChangedEventHandler CurrentStateChanging;
  }
}
