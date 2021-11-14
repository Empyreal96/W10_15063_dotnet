// Decompiled with JetBrains decompiler
// Type: Windows.System.ILaunchUriResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3962022111, 63189, 17866, 145, 58, 112, 164, 12, 92, 130, 33)]
  [ExclusiveTo(typeof (LaunchUriResult))]
  internal interface ILaunchUriResult
  {
    LaunchUriStatus Status { get; }

    ValueSet Result { get; }
  }
}
