// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IRenderingDeviceReplacedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(976333949, 10431, 20090, 133, 36, 113, 103, 157, 72, 15, 56)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RenderingDeviceReplacedEventArgs))]
  internal interface IRenderingDeviceReplacedEventArgs
  {
    CompositionGraphicsDevice GraphicsDevice { get; }
  }
}
