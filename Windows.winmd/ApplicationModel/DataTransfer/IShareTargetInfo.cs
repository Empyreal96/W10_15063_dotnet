// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareTargetInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(945546759, 50920, 16660, 178, 148, 40, 243, 187, 111, 153, 4)]
  [ExclusiveTo(typeof (ShareTargetInfo))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IShareTargetInfo
  {
    string AppUserModelId { get; }

    ShareProvider ShareProvider { get; }
  }
}
