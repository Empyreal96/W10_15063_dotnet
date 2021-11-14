// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.IHdmiDisplayInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [ExclusiveTo(typeof (HdmiDisplayInformation))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1827058272, 62506, 18965, 145, 76, 123, 142, 42, 90, 101, 223)]
  internal interface IHdmiDisplayInformationStatics
  {
    HdmiDisplayInformation GetForCurrentView();
  }
}
