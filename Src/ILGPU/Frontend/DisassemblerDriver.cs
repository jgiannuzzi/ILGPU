﻿// -----------------------------------------------------------------------------
//                                    ILGPU
//                     Copyright (c) 2016-2020 Marcel Koester
//                                www.ilgpu.net
//
// File: DisassemblerDriver.cs
//
// This file is part of ILGPU and is distributed under the University of
// Illinois Open Source License. See LICENSE.txt for details
// -----------------------------------------------------------------------------

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ILGPU.Util;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace ILGPU.Frontend
{
    partial class Disassembler
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        private bool TryDisasembleInstruction(ILOpCode opCode)
        {
            switch (opCode)
            {
                    // Misc
                case ILOpCode.Nop:
                    AppendInstruction(ILInstructionType.Nop, 0, 0);
                    return true;
                case ILOpCode.Break:
                    AppendInstruction(ILInstructionType.Break, 0, 0);
                    return true;

                    // Arguments
                case ILOpCode.Ldarg_0:
                    AppendInstruction(ILInstructionType.Ldarg, 0, 1, 0);
                    return true;
                case ILOpCode.Ldarg_1:
                    AppendInstruction(ILInstructionType.Ldarg, 0, 1, 1);
                    return true;
                case ILOpCode.Ldarg_2:
                    AppendInstruction(ILInstructionType.Ldarg, 0, 1, 2);
                    return true;
                case ILOpCode.Ldarg_3:
                    AppendInstruction(ILInstructionType.Ldarg, 0, 1, 3);
                    return true;
                case ILOpCode.Ldarg_S:
                    AppendInstruction(ILInstructionType.Ldarg, 0, 1, ReadByteArg());
                    return true;
                case ILOpCode.Ldarg:
                    AppendInstruction(ILInstructionType.Ldarg, 0, 1, ReadUShortArg());
                    return true;
                case ILOpCode.Ldarga_S:
                    AppendInstruction(ILInstructionType.Ldarga, 0, 1, ReadByteArg());
                    return true;
                case ILOpCode.Ldarga:
                    AppendInstruction(ILInstructionType.Ldarga, 0, 1, ReadUShortArg());
                    return true;
                case ILOpCode.Starg_S:
                    AppendInstruction(ILInstructionType.Starg, 1, 0, ReadByteArg());
                    return true;
                case ILOpCode.Starg:
                    AppendInstruction(ILInstructionType.Starg, 1, 0, ReadUShortArg());
                    return true;

                // Locals
                case ILOpCode.Ldloc_0:
                    AppendInstruction(ILInstructionType.Ldloc, 0, 1, 0);
                    return true;
                case ILOpCode.Ldloc_1:
                    AppendInstruction(ILInstructionType.Ldloc, 0, 1, 1);
                    return true;
                case ILOpCode.Ldloc_2:
                    AppendInstruction(ILInstructionType.Ldloc, 0, 1, 2);
                    return true;
                case ILOpCode.Ldloc_3:
                    AppendInstruction(ILInstructionType.Ldloc, 0, 1, 3);
                    return true;
                case ILOpCode.Ldloc_S:
                    AppendInstruction(ILInstructionType.Ldloc, 0, 1, ReadByteArg());
                    return true;
                case ILOpCode.Ldloc:
                    AppendInstruction(ILInstructionType.Ldloc, 0, 1, ReadUShortArg());
                    return true;
                case ILOpCode.Ldloca_S:
                    AppendInstruction(ILInstructionType.Ldloca, 0, 1, ReadByteArg());
                    return true;
                case ILOpCode.Ldloca:
                    AppendInstruction(ILInstructionType.Ldloca, 0, 1, ReadUShortArg());
                    return true;
                case ILOpCode.Stloc_0:
                    AppendInstruction(ILInstructionType.Stloc, 1, 0, 0);
                    return true;
                case ILOpCode.Stloc_1:
                    AppendInstruction(ILInstructionType.Stloc, 1, 0, 1);
                    return true;
                case ILOpCode.Stloc_2:
                    AppendInstruction(ILInstructionType.Stloc, 1, 0, 2);
                    return true;
                case ILOpCode.Stloc_3:
                    AppendInstruction(ILInstructionType.Stloc, 1, 0, 3);
                    return true;
                case ILOpCode.Stloc_S:
                    AppendInstruction(ILInstructionType.Stloc, 1, 0, ReadByteArg());
                    return true;
                case ILOpCode.Stloc:
                    AppendInstruction(ILInstructionType.Stloc, 1, 0, ReadUShortArg());
                    return true;

                // Constants
                case ILOpCode.Ldnull:
                    AppendInstruction(ILInstructionType.Ldnull, 0, 1);
                    return true;
                case ILOpCode.Ldc_I4_M1:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, -1);
                    return true;
                case ILOpCode.Ldc_I4_0:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 0);
                    return true;
                case ILOpCode.Ldc_I4_1:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 1);
                    return true;
                case ILOpCode.Ldc_I4_2:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 2);
                    return true;
                case ILOpCode.Ldc_I4_3:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 3);
                    return true;
                case ILOpCode.Ldc_I4_4:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 4);
                    return true;
                case ILOpCode.Ldc_I4_5:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 5);
                    return true;
                case ILOpCode.Ldc_I4_6:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 6);
                    return true;
                case ILOpCode.Ldc_I4_7:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 7);
                    return true;
                case ILOpCode.Ldc_I4_8:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, 8);
                    return true;
                case ILOpCode.Ldc_I4_S:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, ReadSByteArg());
                    return true;
                case ILOpCode.Ldc_I4:
                    AppendInstruction(ILInstructionType.LdI4, 0, 1, ReadIntArg());
                    return true;
                case ILOpCode.Ldc_I8:
                    AppendInstruction(ILInstructionType.LdI8, 0, 1, ReadLongArg());
                    return true;
                case ILOpCode.Ldc_R4:
                    AppendInstruction(ILInstructionType.LdR4, 0, 1, ReadSingleArg());
                    return true;
                case ILOpCode.Ldc_R8:
                    AppendInstruction(ILInstructionType.LdR8, 0, 1, ReadDoubleArg());
                    return true;
                case ILOpCode.Ldstr:
                    AppendInstruction(ILInstructionType.Ldstr, 0, 1, AssociatedModule.ResolveString(ReadIntArg()));
                    return true;

                // Stack
                case ILOpCode.Dup:
                    AppendInstruction(ILInstructionType.Dup, 1, 2);
                    return true;
                case ILOpCode.Pop:
                    AppendInstruction(ILInstructionType.Pop, 1, 0);
                    return true;
                case ILOpCode.Jmp:
                    AppendInstruction(ILInstructionType.Jmp, 0, 0, ResolveMethod(ReadIntArg()));
                    return true;

                    // Call
                case ILOpCode.Call:
                    DisassembleCall(ILInstructionType.Call, ReadIntArg());
                    return true;
                case ILOpCode.Callvirt:
                    DisassembleCall(ILInstructionType.Callvirt, ReadIntArg());
                    return true;
                case ILOpCode.Ret:
                    AppendInstruction(ILInstructionType.Ret, (ushort)MethodBase.GetParameterOffset(), 0, OpCodes.Ret);
                    return true;

                    // Branch
                case ILOpCode.Br_S:
                    AppendInstruction(ILInstructionType.Br, 0, 0, new ILInstructionBranchTargets(ReadShortBranchTarget()));
                    return true;
                case ILOpCode.Br:
                    AppendInstruction(ILInstructionType.Br, 0, 0, new ILInstructionBranchTargets(ReadBranchTarget()));
                    return true;
                case ILOpCode.Brfalse_S:
                    AppendInstruction(ILInstructionType.Brfalse, 1, 0, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Brfalse:
                    AppendInstruction(ILInstructionType.Brfalse, 1, 0, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Brtrue_S:
                    AppendInstruction(ILInstructionType.Brtrue, 1, 0, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Brtrue:
                    AppendInstruction(ILInstructionType.Brtrue, 1, 0, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Beq_S:
                    AppendInstruction(ILInstructionType.Beq, 2, 0, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Beq:
                    AppendInstruction(ILInstructionType.Beq, 2, 0, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bge_S:
                    AppendInstruction(ILInstructionType.Bge, 2, 0, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bge:
                    AppendInstruction(ILInstructionType.Bge, 2, 0, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bgt_S:
                    AppendInstruction(ILInstructionType.Bgt, 2, 0, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bgt:
                    AppendInstruction(ILInstructionType.Bgt, 2, 0, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Ble_S:
                    AppendInstruction(ILInstructionType.Ble, 2, 0, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Ble:
                    AppendInstruction(ILInstructionType.Ble, 2, 0, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Blt_S:
                    AppendInstruction(ILInstructionType.Blt, 2, 0, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Blt:
                    AppendInstruction(ILInstructionType.Blt, 2, 0, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bne_Un_S:
                    AppendInstructionWithFlags(ILInstructionType.Bne, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bne_Un:
                    AppendInstructionWithFlags(ILInstructionType.Bne, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bge_Un_S:
                    AppendInstructionWithFlags(ILInstructionType.Bge, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bge_Un:
                    AppendInstructionWithFlags(ILInstructionType.Bge, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bgt_Un_S:
                    AppendInstructionWithFlags(ILInstructionType.Bgt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Bgt_Un:
                    AppendInstructionWithFlags(ILInstructionType.Bgt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Ble_Un_S:
                    AppendInstructionWithFlags(ILInstructionType.Ble, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Ble_Un:
                    AppendInstructionWithFlags(ILInstructionType.Ble, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Blt_Un_S:
                    AppendInstructionWithFlags(ILInstructionType.Blt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadShortBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Blt_Un:
                    AppendInstructionWithFlags(ILInstructionType.Blt, 2, 0, ILInstructionFlags.Unsigned, new ILInstructionBranchTargets(ReadBranchTarget(), ilOffset));
                    return true;
                case ILOpCode.Switch:
                    {
                        uint numSwitchTargets = ReadUIntArg();
                        int[] switchTargets = new int[numSwitchTargets + 1];
                        var switchBaseOffset = switchTargets[0] = ilOffset + sizeof(int) * (int)numSwitchTargets;
                        for (int i = 0, e = (int)numSwitchTargets; i < e; ++i)
                            switchTargets[i + 1] = switchBaseOffset + ReadIntArg();
                        AppendInstruction(ILInstructionType.Switch, 1, 0, new ILInstructionBranchTargets(switchTargets));
                    }
                    return true;

                    // Arithmetic
                case ILOpCode.Add:
                    AppendInstructionWithFlags(ILInstructionType.Add, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Add_Ovf:
                    AppendInstructionWithFlags(ILInstructionType.Add, 2, 1, ILInstructionFlags.Overflow);
                    return true;
                case ILOpCode.Add_Ovf_Un:
                    AppendInstructionWithFlags(ILInstructionType.Add, 2, 1, ILInstructionFlags.Unsigned | ILInstructionFlags.Overflow);
                    return true;
                case ILOpCode.Sub:
                    AppendInstructionWithFlags(ILInstructionType.Sub, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Sub_Ovf:
                    AppendInstructionWithFlags(ILInstructionType.Sub, 2, 1, ILInstructionFlags.Overflow);
                    return true;
                case ILOpCode.Sub_Ovf_Un:
                    AppendInstructionWithFlags(ILInstructionType.Sub, 2, 1, ILInstructionFlags.Unsigned | ILInstructionFlags.Overflow);
                    return true;
                case ILOpCode.Mul:
                    AppendInstructionWithFlags(ILInstructionType.Mul, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Mul_Ovf:
                    AppendInstructionWithFlags(ILInstructionType.Mul, 2, 1, ILInstructionFlags.Overflow);
                    return true;
                case ILOpCode.Mul_Ovf_Un:
                    AppendInstructionWithFlags(ILInstructionType.Mul, 2, 1, ILInstructionFlags.Unsigned | ILInstructionFlags.Overflow);
                    return true;
                case ILOpCode.Div:
                    AppendInstructionWithFlags(ILInstructionType.Div, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Div_Un:
                    AppendInstructionWithFlags(ILInstructionType.Div, 2, 1, ILInstructionFlags.Unsigned);
                    return true;
                case ILOpCode.Rem:
                    AppendInstructionWithFlags(ILInstructionType.Rem, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Rem_Un:
                    AppendInstructionWithFlags(ILInstructionType.Rem, 2, 1, ILInstructionFlags.Unsigned);
                    return true;
                case ILOpCode.And:
                    AppendInstructionWithFlags(ILInstructionType.And, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Or:
                    AppendInstructionWithFlags(ILInstructionType.Or, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Xor:
                    AppendInstructionWithFlags(ILInstructionType.Xor, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Shl:
                    AppendInstructionWithFlags(ILInstructionType.Shl, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Shr:
                    AppendInstructionWithFlags(ILInstructionType.Shr, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Shr_Un:
                    AppendInstructionWithFlags(ILInstructionType.Shr, 2, 1, ILInstructionFlags.Unsigned);
                    return true;
                case ILOpCode.Neg:
                    AppendInstructionWithFlags(ILInstructionType.Neg, 1, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Not:
                    AppendInstructionWithFlags(ILInstructionType.Not, 1, 1, ILInstructionFlags.None);
                    return true;

                    // Conversion
                case ILOpCode.Conv_I1:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(sbyte));
                    return true;
                case ILOpCode.Conv_I2:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(short));
                    return true;
                case ILOpCode.Conv_I4:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(int));
                    return true;
                case ILOpCode.Conv_I8:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(long));
                    return true;
                case ILOpCode.Conv_I:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, NativePtrType);
                    return true;
                case ILOpCode.Conv_Ovf_I1:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(sbyte));
                    return true;
                case ILOpCode.Conv_Ovf_I2:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(short));
                    return true;
                case ILOpCode.Conv_Ovf_I4:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(int));
                    return true;
                case ILOpCode.Conv_Ovf_I8:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(long));
                    return true;
                case ILOpCode.Conv_Ovf_I:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, NativePtrType);
                    return true;
                case ILOpCode.Conv_Ovf_I1_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(sbyte));
                    return true;
                case ILOpCode.Conv_Ovf_I2_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(short));
                    return true;
                case ILOpCode.Conv_Ovf_I4_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(int));
                    return true;
                case ILOpCode.Conv_Ovf_I8_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(long));
                    return true;
                case ILOpCode.Conv_Ovf_I_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, NativePtrType);
                    return true;
                case ILOpCode.Conv_R4:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(float));
                    return true;
                case ILOpCode.Conv_R8:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(double));
                    return true;
                case ILOpCode.Conv_R_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Unsigned, typeof(double));
                    return true;
                case ILOpCode.Conv_U1:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(byte));
                    return true;
                case ILOpCode.Conv_U2:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(ushort));
                    return true;
                case ILOpCode.Conv_U4:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(uint));
                    return true;
                case ILOpCode.Conv_U8:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, typeof(ulong));
                    return true;
                case ILOpCode.Conv_U:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.None, NativePtrType);
                    return true;
                case ILOpCode.Conv_Ovf_U1:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(byte));
                    return true;
                case ILOpCode.Conv_Ovf_U2:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(ushort));
                    return true;
                case ILOpCode.Conv_Ovf_U4:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(uint));
                    return true;
                case ILOpCode.Conv_Ovf_U8:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, typeof(ulong));
                    return true;
                case ILOpCode.Conv_Ovf_U:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow, NativePtrType);
                    return true;
                case ILOpCode.Conv_Ovf_U1_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(byte));
                    return true;
                case ILOpCode.Conv_Ovf_U2_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(ushort));
                    return true;
                case ILOpCode.Conv_Ovf_U4_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(uint));
                    return true;
                case ILOpCode.Conv_Ovf_U8_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, typeof(ulong));
                    return true;
                case ILOpCode.Conv_Ovf_U_Un:
                    AppendInstructionWithFlags(ILInstructionType.Conv, 1, 1, ILInstructionFlags.Overflow | ILInstructionFlags.Unsigned, NativePtrType);
                    return true;

                    // General Objects
                case ILOpCode.Initobj:
                    AppendInstruction(ILInstructionType.Initobj, 1, 0, ReadTypeArg());
                    return true;
                case ILOpCode.Newobj:
                    DisassembleCall(ILInstructionType.Newobj, ReadIntArg());
                    return true;
                case ILOpCode.Newarr:
                    AppendInstruction(ILInstructionType.Newarr, 1, 1, ReadTypeArg());
                    return true;

                    // Boxing
                case ILOpCode.Box:
                    AppendInstruction(ILInstructionType.Box, 1, 1, ReadTypeArg());
                    return true;
                case ILOpCode.Unbox:
                    AppendInstruction(ILInstructionType.Unbox, 1, 1, ReadTypeArg());
                    return true;
                case ILOpCode.Unbox_Any:
                    {
                        var type = ResolveType(ReadIntArg());
                        AppendInstruction(ILInstructionType.Unbox, 1, 1, type);
                        AppendInstruction(ILInstructionType.Ldobj, 1, 1, type);
                    }
                    return true;

                case ILOpCode.Castclass:
                    AppendInstruction(ILInstructionType.Castclass, 1, 1, ReadTypeArg());
                    return true;
                case ILOpCode.Isinst:
                    AppendInstruction(ILInstructionType.Isinst, 1, 1, ReadTypeArg());
                    return true;

                    // Fields
                case ILOpCode.Ldfld:
                    AppendInstruction(ILInstructionType.Ldfld, 1, 1, ReadFieldArg());
                    return true;
                case ILOpCode.Ldflda:
                    AppendInstruction(ILInstructionType.Ldflda, 1, 1, ReadFieldArg());
                    return true;
                case ILOpCode.Ldsfld:
                    AppendInstruction(ILInstructionType.Ldsfld, 0, 1, ReadFieldArg());
                    return true;
                case ILOpCode.Ldsflda:
                    AppendInstruction(ILInstructionType.Ldsflda, 0, 1, ReadFieldArg());
                    return true;
                case ILOpCode.Stfld:
                    AppendInstruction(ILInstructionType.Stfld, 2, 0, ReadFieldArg());
                    return true;
                case ILOpCode.Stsfld:
                    AppendInstruction(ILInstructionType.Stsfld, 1, 0, ReadFieldArg());
                    return true;

                    // Indirect Objects
                case ILOpCode.Ldobj:
                    AppendInstruction(ILInstructionType.Ldobj, 1, 1, ReadTypeArg());
                    return true;
                case ILOpCode.Stobj:
                    AppendInstruction(ILInstructionType.Stobj, 2, 0, ReadTypeArg());
                    return true;
                case ILOpCode.Cpobj:
                    AppendInstruction(ILInstructionType.Cpobj, 2, 0, ReadTypeArg());
                    return true;

                    // Arrays
                case ILOpCode.Ldlen:
                    AppendInstruction(ILInstructionType.Ldlen, 1, 1);
                    return true;
                case ILOpCode.Ldelem_I1:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(sbyte));
                    return true;
                case ILOpCode.Ldelem_U1:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(byte));
                    return true;
                case ILOpCode.Ldelem_I2:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(short));
                    return true;
                case ILOpCode.Ldelem_U2:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(ushort));
                    return true;
                case ILOpCode.Ldelem_I4:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(int));
                    return true;
                case ILOpCode.Ldelem_U4:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(uint));
                    return true;
                case ILOpCode.Ldelem_I8:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(long));
                    return true;
                case ILOpCode.Ldelem_R4:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(float));
                    return true;
                case ILOpCode.Ldelem_R8:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, typeof(double));
                    return true;
                case ILOpCode.Ldelem_Ref:
                case ILOpCode.Ldelem:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, ReadTypeArg());
                    return true;
                case ILOpCode.Ldelem_I:
                    AppendInstruction(ILInstructionType.Ldelem, 2, 1, NativePtrType);
                    return true;
                case ILOpCode.Ldelema:
                    AppendInstruction(ILInstructionType.Ldelema, 2, 1, ReadTypeArg());
                    return true;
                case ILOpCode.Stelem_I1:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(sbyte));
                    return true;
                case ILOpCode.Stelem_I2:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(short));
                    return true;
                case ILOpCode.Stelem_I4:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(int));
                    return true;
                case ILOpCode.Stelem_I8:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(long));
                    return true;
                case ILOpCode.Stelem_R4:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(float));
                    return true;
                case ILOpCode.Stelem_R8:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, typeof(double));
                    return true;
                case ILOpCode.Stelem_I:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, NativePtrType);
                    return true;
                case ILOpCode.Stelem_Ref:
                case ILOpCode.Stelem:
                    AppendInstruction(ILInstructionType.Stelem, 3, 0, ReadTypeArg());
                    return true;

                    // Compare
                case ILOpCode.Ceq:
                    AppendInstructionWithFlags(ILInstructionType.Ceq, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Cgt:
                    AppendInstructionWithFlags(ILInstructionType.Cgt, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Cgt_Un:
                    AppendInstructionWithFlags(ILInstructionType.Cgt, 2, 1, ILInstructionFlags.Unsigned);
                    return true;
                case ILOpCode.Clt:
                    AppendInstructionWithFlags(ILInstructionType.Clt, 2, 1, ILInstructionFlags.None);
                    return true;
                case ILOpCode.Clt_Un:
                    AppendInstructionWithFlags(ILInstructionType.Clt, 2, 1, ILInstructionFlags.Unsigned);
                    return true;

                    // Indirect
                case ILOpCode.Ldind_I1:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(sbyte));
                    return true;
                case ILOpCode.Ldind_I2:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(short));
                    return true;
                case ILOpCode.Ldind_I4:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(int));
                    return true;
                case ILOpCode.Ldind_I8:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(long));
                    return true;
                case ILOpCode.Ldind_U1:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(byte));
                    return true;
                case ILOpCode.Ldind_U2:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(ushort));
                    return true;
                case ILOpCode.Ldind_U4:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(uint));
                    return true;
                case ILOpCode.Ldind_R4:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(float));
                    return true;
                case ILOpCode.Ldind_R8:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, typeof(double));
                    return true;
                case ILOpCode.Ldind_I:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, NativePtrType);
                    return true;
                case ILOpCode.Ldind_Ref:
                    AppendInstruction(ILInstructionType.Ldind, 1, 1, ReadTypeArg());
                    return true;
                case ILOpCode.Stind_I1:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(byte));
                    return true;
                case ILOpCode.Stind_I2:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(short));
                    return true;
                case ILOpCode.Stind_I4:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(int));
                    return true;
                case ILOpCode.Stind_I8:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(long));
                    return true;
                case ILOpCode.Stind_R4:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(float));
                    return true;
                case ILOpCode.Stind_R8:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, typeof(double));
                    return true;
                case ILOpCode.Stind_I:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, NativePtrType);
                    return true;
                case ILOpCode.Stind_Ref:
                    AppendInstruction(ILInstructionType.Stind, 2, 0, ReadTypeArg());
                    return true;
                case ILOpCode.Localloc:
                    AppendInstruction(ILInstructionType.Localloc, 1, 1, ReadTypeArg());
                    return true;

                    // Blk
                case ILOpCode.Cpblk:
                    AppendInstruction(ILInstructionType.Cpblk, 3, 0);
                    return true;
                case ILOpCode.Initblk:
                    AppendInstruction(ILInstructionType.Initblk, 3, 0);
                    return true;

                    // SizeOf
                case ILOpCode.Sizeof:
                    AppendInstruction(ILInstructionType.SizeOf, 0, 1, ReadTypeArg());
                    return true;

                // Token
                case ILOpCode.Ldtoken:
                    AppendInstruction(ILInstructionType.LdToken, 0, 1, AssociatedModule.ResolveMember(ReadIntArg()));
                    return true;

                default:
                    return false;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool TryDisassemblePrefix(ILOpCode opCode)
        {
            switch (opCode)
            {
                case ILOpCode.No:
                    AddFlags(ILInstructionFlags.Unchecked);
                    return true;
                case ILOpCode.Unaligned:
                    AddFlags(ILInstructionFlags.Unaligned);
                    return true;
                case ILOpCode.Volatile:
                    AddFlags(ILInstructionFlags.Volatile);
                    return true;
                case ILOpCode.Readonly:
                    AddFlags(ILInstructionFlags.ReadOnly);
                    return true;
                case ILOpCode.Tail:
                    AddFlags(ILInstructionFlags.Tail);
                    return true;
                case ILOpCode.Constrained: 
                    AddFlags(ILInstructionFlags.Constrained);
                    flagsArgument = ReadTypeArg();
                    return true;
                default:
                    return false;
            }
        }
    }
}
