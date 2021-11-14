// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailIrmTemplate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IEmailIrmTemplateFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailIrmTemplate : IEmailIrmTemplate
  {
    [MethodImpl]
    public extern EmailIrmTemplate(string id, string name, string description);

    [MethodImpl]
    public extern EmailIrmTemplate();

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }
  }
}
