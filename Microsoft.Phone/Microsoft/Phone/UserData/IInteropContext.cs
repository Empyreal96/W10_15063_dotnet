// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.IInteropContext
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Security;

namespace Microsoft.Phone.UserData
{
  internal interface IInteropContext
  {
    [SecurityCritical]
    uint Init();

    [SecurityCritical]
    uint GetOptimalBatchSize();

    [SecurityCritical]
    uint GetObjectsEnumerator(string query, out object handle);

    [SecurityCritical]
    uint MoveNext(object handle, uint requestedCount, ref object[] objectHandles);

    [SecurityCritical]
    void FreeEnumerator(object handle);

    [SecurityCritical]
    void FreeObject(object handle);
  }
}
