// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.PoomDataServiceInteropContext
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecurityCritical]
  internal class PoomDataServiceInteropContext : IInteropContext
  {
    [SecurityCritical]
    public uint Init() => PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_Init();

    [SecurityCritical]
    public uint GetOptimalBatchSize() => 100;

    [SecurityCritical]
    public uint GetObjectsEnumerator(string query, out object handle)
    {
      IntPtr handle1;
      int objectsEnumerator = (int) PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_GetObjectsEnumerator(query, out handle1);
      handle = (object) handle1;
      return (uint) objectsEnumerator;
    }

    [SecurityCritical]
    public uint MoveNext(object handle, uint requestedCount, ref object[] objectHandles)
    {
      uint handleCount = 0;
      IntPtr[] objectHandles1 = new IntPtr[(int) requestedCount];
      uint num = PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_MoveNext((IntPtr) handle, requestedCount, ref handleCount, objectHandles1);
      try
      {
        objectHandles = new object[(int) handleCount];
        switch (num)
        {
          case 0:
            for (int index = 0; (long) index < (long) handleCount; ++index)
              objectHandles[index] = (object) objectHandles1[index];
            break;
          case 2147943568:
            num = 0U;
            break;
        }
        return num;
      }
      catch (Exception ex)
      {
        for (int index = 0; (long) index < (long) handleCount; ++index)
          this.FreeObject((object) objectHandles1[index]);
        throw;
      }
    }

    [SecurityCritical]
    internal bool TryGetContactPictureStream(uint contactId, out IntPtr streamHandle)
    {
      uint contactPictureStream = PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_GetContactPictureStream(contactId, out streamHandle);
      if (contactPictureStream == 2147943568U)
        return false;
      this.HandleHRESULT(contactPictureStream);
      return true;
    }

    [SecurityCritical]
    internal unsafe int ReadStream(IntPtr handle, byte[] buffer, int offset, int count)
    {
      byte[] numArray1 = new byte[count];
      int read = 0;
      byte[] numArray2 = numArray1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      fixed (byte* buffer1 = &^(numArray1 == null || numArray2.Length == 0 ? (byte&) IntPtr.Zero : ref numArray2[0]))
        this.HandleHRESULT(PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_ReadStream(handle, count, buffer1, out read));
      Buffer.BlockCopy((Array) numArray1, 0, (Array) buffer, offset, read);
      return read;
    }

    [SecurityCritical]
    internal long SeekStream(IntPtr handle, long offset, SeekOrigin origin)
    {
      uint nativeSeekOrigin = this.ManagedToNativeSeekOrigin(origin);
      long newPosition;
      this.HandleHRESULT(PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_SeekStream(handle, offset, nativeSeekOrigin, out newPosition));
      return newPosition;
    }

    [SecurityCritical]
    internal long GetStreamLength(IntPtr handle)
    {
      long length;
      this.HandleHRESULT(PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_GetStreamLength(handle, out length));
      return length;
    }

    [SecurityCritical]
    internal void FreeStream(IntPtr handle)
    {
      int num = (int) PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_FreeStream(handle);
    }

    [SecurityCritical]
    public void FreeEnumerator(object handle) => PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_FreeEnumerator((IntPtr) handle);

    [SecurityCritical]
    public void FreeObject(object handle) => PoomDataServiceInteropContext.PoomInteropMethods.PoomDataServiceClient_FreeObject((IntPtr) handle);

    private uint ManagedToNativeSeekOrigin(SeekOrigin origin)
    {
      switch (origin)
      {
        case SeekOrigin.Begin:
          return 0;
        case SeekOrigin.Current:
          return 1;
        case SeekOrigin.End:
          return 2;
        default:
          throw new ArgumentException("Invalid SeekOrigin");
      }
    }

    private void HandleHRESULT(uint hr)
    {
      if (hr != 0U)
        throw new Exception();
    }

    [SecurityCritical]
    private static class PoomInteropMethods
    {
      private const string PoomDataServiceClientDll = "CommsDirectAccessClient.dll";

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      public static extern uint PoomDataServiceClient_Init();

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll", CharSet = CharSet.Unicode)]
      public static extern uint PoomDataServiceClient_GetObjectsEnumerator(
        string query,
        out IntPtr handle);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      public static extern uint PoomDataServiceClient_MoveNext(
        IntPtr handle,
        uint batchSize,
        ref uint handleCount,
        [MarshalAs(UnmanagedType.LPArray), In, Out] IntPtr[] objectHandles);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      internal static extern uint PoomDataServiceClient_GetContactPictureStream(
        uint contactId,
        out IntPtr handle);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      internal static extern unsafe uint PoomDataServiceClient_ReadStream(
        IntPtr handle,
        int length,
        byte* buffer,
        out int read);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      internal static extern uint PoomDataServiceClient_SeekStream(
        IntPtr handle,
        long offset,
        uint origin,
        out long newPosition);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      internal static extern uint PoomDataServiceClient_GetStreamLength(
        IntPtr handle,
        out long length);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      internal static extern uint PoomDataServiceClient_FreeStream(IntPtr handle);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      public static extern void PoomDataServiceClient_FreeEnumerator(IntPtr handle);

      [SecurityCritical]
      [DllImport("CommsDirectAccessClient.dll")]
      public static extern void PoomDataServiceClient_FreeObject(IntPtr handle);
    }
  }
}
