// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.UserAsyncDispatcherUnsafeNativeMethodsXboxZune
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework
{
  [SecurityCritical]
  internal static class UserAsyncDispatcherUnsafeNativeMethodsXboxZune
  {
    private const string interop = "XnaFrameworkCore";

    [DllImport("XnaFrameworkCore", EntryPoint = "KernelAsyncDispatcher_Initialize_Entrypoint")]
    internal static extern KernelReturnCode KernelAsyncDispatcher_Initialize();

    [DllImport("XnaFrameworkCore")]
    internal static extern void KernelAsyncDispatcher_Shutdown();

    [DllImport("XnaFrameworkCore", EntryPoint = "KernelAsyncDispatcher_WaitForAsyncOperationToFinish_Entrypoint")]
    internal static extern KernelReturnCode WaitForAsyncOperationToFinish(
      out ManagedCallType managedCallType,
      out uint managedCallArgs);
  }
}
