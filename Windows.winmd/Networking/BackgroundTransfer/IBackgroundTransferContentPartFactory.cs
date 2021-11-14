// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPartFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(2431621289, 31233, 18955, 159, 128, 160, 176, 187, 55, 15, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTransferContentPartFactory
  {
    BackgroundTransferContentPart CreateWithName(string name);

    BackgroundTransferContentPart CreateWithNameAndFileName(
      string name,
      string fileName);
  }
}
