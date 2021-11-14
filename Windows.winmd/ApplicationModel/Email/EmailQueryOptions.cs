// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IEmailQueryOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailQueryOptions : IEmailQueryOptions
  {
    [MethodImpl]
    public extern EmailQueryOptions(string text);

    [MethodImpl]
    public extern EmailQueryOptions(string text, EmailQuerySearchFields fields);

    [MethodImpl]
    public extern EmailQueryOptions();

    public extern EmailQueryTextSearch TextSearch { [MethodImpl] get; }

    public extern EmailQuerySortDirection SortDirection { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailQuerySortProperty SortProperty { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailQueryKind Kind { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> FolderIds { [MethodImpl] get; }
  }
}
