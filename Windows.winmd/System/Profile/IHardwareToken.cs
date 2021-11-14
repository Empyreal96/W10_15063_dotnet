// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IHardwareToken
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  [Guid(687264960, 64274, 16548, 129, 103, 127, 78, 3, 210, 114, 76)]
  [ContractVersion(typeof (ProfileHardwareTokenContract), 65536)]
  [ExclusiveTo(typeof (HardwareToken))]
  internal interface IHardwareToken
  {
    IBuffer Id { get; }

    IBuffer Signature { get; }

    IBuffer Certificate { get; }
  }
}
