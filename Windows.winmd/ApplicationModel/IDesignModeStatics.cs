// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IDesignModeStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(741905356, 63514, 20090, 184, 87, 118, 168, 8, 135, 225, 133)]
  [ExclusiveTo(typeof (DesignMode))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDesignModeStatics
  {
    bool DesignModeEnabled { get; }
  }
}
