// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CompositionObject))]
  [WebHostHidden]
  [Guid(3165957445, 30217, 17744, 147, 79, 22, 0, 42, 104, 253, 237)]
  internal interface ICompositionObject
  {
    Compositor Compositor { get; }

    CoreDispatcher Dispatcher { get; }

    CompositionPropertySet Properties { get; }

    void StartAnimation(string propertyName, CompositionAnimation animation);

    void StopAnimation(string propertyName);
  }
}
