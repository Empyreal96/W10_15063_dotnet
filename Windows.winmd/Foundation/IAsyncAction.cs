// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncAction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(1516535814, 33850, 19881, 134, 91, 157, 38, 229, 223, 173, 123)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncAction : IAsyncInfo
  {
    AsyncActionCompletedHandler Completed { set; get; }

    void GetResults();
  }
}
