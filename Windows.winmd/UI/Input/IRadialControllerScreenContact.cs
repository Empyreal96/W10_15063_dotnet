// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerScreenContact
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerScreenContact))]
  [Guid(543859764, 58961, 4581, 191, 98, 44, 39, 215, 64, 78, 133)]
  internal interface IRadialControllerScreenContact
  {
    Rect Bounds { get; }

    Point Position { get; }
  }
}
