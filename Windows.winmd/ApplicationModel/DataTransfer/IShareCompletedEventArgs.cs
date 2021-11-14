// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(1165280322, 63763, 20320, 157, 247, 204, 64, 96, 171, 25, 22)]
  [ExclusiveTo(typeof (ShareCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IShareCompletedEventArgs
  {
    ShareTargetInfo ShareTarget { get; }
  }
}
