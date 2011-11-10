/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.35
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace be.portugal.eid {

using System;
using System.Runtime.InteropServices;

/// <summary>
/// Exception class Command Not Supported (error code = EIDMW_ERR_NOT_SUPPORTED).
/// Throw when the command asked is not supported by the card.
/// </summary>
public class PTEID_ExCmdNotSupported : PTEID_Exception {
  private HandleRef swigCPtr;

  internal PTEID_ExCmdNotSupported(IntPtr cPtr, bool cMemoryOwn) : base(pteidlib_dotNetPINVOKE.PTEID_ExCmdNotSupportedUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PTEID_ExCmdNotSupported obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PTEID_ExCmdNotSupported() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        pteidlib_dotNetPINVOKE.delete_PTEID_ExCmdNotSupported(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PTEID_ExCmdNotSupported() : this(pteidlib_dotNetPINVOKE.new_PTEID_ExCmdNotSupported(), true) {
  }

}

}
