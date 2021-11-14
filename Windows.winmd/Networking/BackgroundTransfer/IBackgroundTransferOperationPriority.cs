// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferOperationPriority
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(75842343, 21076, 19258, 145, 94, 10, 164, 146, 117, 192, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTransferOperationPriority
  {
    BackgroundTransferPriority Priority { get; set; }
  }
}
