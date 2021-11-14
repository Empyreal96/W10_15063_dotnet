// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IExposurePriorityVideoControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ExposurePriorityVideoControl))]
  [Guid(749879459, 20840, 17009, 158, 165, 71, 98, 26, 152, 163, 82)]
  internal interface IExposurePriorityVideoControl
  {
    bool Supported { get; }

    bool Enabled { get; set; }
  }
}
