// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FileExtensionVector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileExtensionVector : IVector<string>, IIterable<string>
  {
    [MethodImpl]
    public extern string GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<string> GetView();

    [MethodImpl]
    public extern bool IndexOf(string value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, string value);

    [MethodImpl]
    public extern void InsertAt(uint index, string value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(string value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] string[] items);

    [MethodImpl]
    public extern void ReplaceAll(string[] items);

    [MethodImpl]
    public extern IIterator<string> First();
  }
}
