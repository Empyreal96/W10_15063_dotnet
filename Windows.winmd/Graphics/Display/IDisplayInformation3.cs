// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(3675586845, 3849, 17510, 143, 243, 17, 222, 154, 60, 146, 154)]
  [ExclusiveTo(typeof (DisplayInformation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDisplayInformation3
  {
    IReference<double> DiagonalSizeInInches { get; }
  }
}
