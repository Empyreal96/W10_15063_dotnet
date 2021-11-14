// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenuItemStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerMenuItem))]
  [Guid(614336647, 55362, 17700, 157, 248, 224, 214, 71, 237, 200, 135)]
  internal interface IRadialControllerMenuItemStatics
  {
    RadialControllerMenuItem CreateFromIcon(
      string displayText,
      RandomAccessStreamReference icon);

    RadialControllerMenuItem CreateFromKnownIcon(
      string displayText,
      RadialControllerMenuKnownIcon value);
  }
}
