// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.ITextResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3922425027, 9303, 19675, 129, 16, 114, 245, 232, 232, 131, 232)]
  [ExclusiveTo(typeof (TextResponse))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface ITextResponse
  {
    uint Id { get; }

    string Content { get; }
  }
}
