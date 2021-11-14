// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ISceneModeControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3566099191, 36185, 18516, 140, 98, 18, 199, 11, 168, 155, 124)]
  [ExclusiveTo(typeof (SceneModeControl))]
  internal interface ISceneModeControl
  {
    IVectorView<CaptureSceneMode> SupportedModes { get; }

    CaptureSceneMode Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(CaptureSceneMode sceneMode);
  }
}
