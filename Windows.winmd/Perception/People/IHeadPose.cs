// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.IHeadPose
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.People
{
  [ExclusiveTo(typeof (HeadPose))]
  [Guid(2136655269, 18907, 14239, 148, 41, 50, 162, 250, 243, 79, 166)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IHeadPose
  {
    Vector3 Position { get; }

    Vector3 ForwardDirection { get; }

    Vector3 UpDirection { get; }
  }
}
