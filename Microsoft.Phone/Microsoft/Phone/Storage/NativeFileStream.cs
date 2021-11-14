// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Storage.NativeFileStream
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Storage
{
  [SecuritySafeCritical]
  internal class NativeFileStream : Stream
  {
    private NativeFileSafeHandle m_handle;

    [SecuritySafeCritical]
    internal static NativeFileStream OpenFile(string fileName)
    {
      NativeFileSafeHandle file = NativeFileStream.CreateFile(fileName, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete, IntPtr.Zero, FileMode.Open, FileAttributes.Normal, IntPtr.Zero);
      if (file.IsInvalid)
        Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
      return new NativeFileStream(file);
    }

    [SecuritySafeCritical]
    internal static NativeFileStream OpenFileFromToken(string tokenId)
    {
      NativeFileSafeHandle handle;
      Marshal.ThrowExceptionForHR(NativeFileStream.DSOpenSharedFile(tokenId, 0, out handle));
      return new NativeFileStream(handle);
    }

    [SecurityCritical]
    [DllImport("dsclient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int DSOpenSharedFile(
      [MarshalAs(UnmanagedType.LPWStr)] string tokenId,
      int dwShareAttributes,
      out NativeFileSafeHandle handle);

    [DllImport("API-MS-Win-Core-File-L1-1-1.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern NativeFileSafeHandle CreateFile(
      string lpFileName,
      [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess,
      [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode,
      IntPtr lpSecurityAttributes,
      [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition,
      [MarshalAs(UnmanagedType.U4)] FileAttributes dwFlagsAndAttributes,
      IntPtr hTemplateFile);

    [DllImport("API-MS-Win-Core-File-L1-1-1.dll", SetLastError = true)]
    private static extern bool ReadFile(
      NativeFileSafeHandle handle,
      [Out] byte[] lpBuffer,
      uint cbToRead,
      out uint cbNumBytesRead,
      IntPtr lpOverlapped);

    [DllImport("API-MS-Win-Core-File-L1-1-1.dll", SetLastError = true)]
    private static extern uint SetFilePointer(
      NativeFileSafeHandle handle,
      uint lDistanceToMove,
      [In, Out] ref uint lDistanceToMoveHigh,
      NativeFileStream.SetFileMoveMethod dwMoveMethod);

    [DllImport("api-ms-win-core-file-l1-1-1.dll", SetLastError = true)]
    private static extern int GetFileSize(NativeFileSafeHandle handle, int high);

    [SecuritySafeCritical]
    private NativeFileStream(NativeFileSafeHandle handle) => this.m_handle = handle;

    public override bool CanRead => true;

    public override bool CanSeek => true;

    public override bool CanWrite => false;

    public override void Flush()
    {
    }

    public override long Length
    {
      [SecuritySafeCritical] get
      {
        int high = 0;
        ulong fileSize = (ulong) NativeFileStream.GetFileSize(this.m_handle, high);
        return ((long) high << 32) + (long) fileSize;
      }
    }

    public override long Position
    {
      get => this.Seek(0L, SeekOrigin.Current);
      set => this.Seek(value, SeekOrigin.Begin);
    }

    [SecuritySafeCritical]
    public override int Read(byte[] buffer, int offset, int count)
    {
      if (buffer == null)
        throw new ArgumentNullException(nameof (buffer));
      if (offset + count > buffer.Length)
        throw new ArgumentException(nameof (count));
      if (offset < 0 || count < 0)
        throw new ArgumentException();
      byte[] lpBuffer = buffer;
      if (offset != 0)
        lpBuffer = new byte[count];
      uint cbNumBytesRead;
      if (!NativeFileStream.ReadFile(this.m_handle, lpBuffer, (uint) count, out cbNumBytesRead, IntPtr.Zero))
        Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
      if (lpBuffer != buffer)
        Array.Copy((Array) lpBuffer, 0, (Array) buffer, offset, count);
      return (int) cbNumBytesRead;
    }

    [SecuritySafeCritical]
    public override long Seek(long offset, SeekOrigin origin)
    {
      NativeFileStream.SetFileMoveMethod dwMoveMethod;
      switch (origin)
      {
        case SeekOrigin.Begin:
          dwMoveMethod = NativeFileStream.SetFileMoveMethod.Begin;
          break;
        case SeekOrigin.Current:
          dwMoveMethod = NativeFileStream.SetFileMoveMethod.Current;
          break;
        case SeekOrigin.End:
          dwMoveMethod = NativeFileStream.SetFileMoveMethod.End;
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof (origin));
      }
      long num1 = offset;
      uint lDistanceToMove = (uint) ((ulong) (num1 & -4294967296L) >> 32);
      uint lDistanceToMoveHigh = (uint) ((ulong) num1 & (ulong) uint.MaxValue);
      uint num2 = NativeFileStream.SetFilePointer(this.m_handle, lDistanceToMove, ref lDistanceToMoveHigh, dwMoveMethod);
      return ((long) lDistanceToMove << 32) + (long) num2;
    }

    public override void SetLength(long value) => throw new InvalidOperationException();

    public override void Write(byte[] buffer, int offset, int count) => throw new InvalidOperationException();

    [SecuritySafeCritical]
    public override void Close() => this.m_handle.Close();

    private enum SetFileMoveMethod : uint
    {
      Begin,
      Current,
      End,
    }
  }
}
