// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTargetInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ShareTargetInfo : IShareTargetInfo
  {
    public extern string AppUserModelId { [MethodImpl] get; }

    public extern ShareProvider ShareProvider { [MethodImpl] get; }
  }
}
