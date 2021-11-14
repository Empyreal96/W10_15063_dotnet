// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DTaskSourceChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Print3DTaskSourceChangedEventArgs))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(1540175023, 9449, 19472, 141, 7, 20, 195, 70, 186, 63, 207)]
  internal interface IPrint3DTaskSourceChangedEventArgs
  {
    Printing3D3MFPackage Source { get; }
  }
}
