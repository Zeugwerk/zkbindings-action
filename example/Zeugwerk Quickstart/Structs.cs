/* Generated code */
using System;
using System.Runtime.InteropServices;
using PLC.Enums;

namespace PLC
{
    namespace Types
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct String256
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string str;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct String81
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
            public string str;
        }
        public struct Array_0_10_ZApplication_AlarmingAcknowledge
        {
            public ZApplication_AlarmingAcknowledge this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public ZApplication_AlarmingAcknowledge[] data;
        }
        public struct Array_0_5_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] data;
        }
        public struct Array_0_0_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public byte[] data;
        }
        public struct Array_0_10_ZApplication_AlarmingMessageCom
        {
            public ZApplication_AlarmingMessageCom this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public ZApplication_AlarmingMessageCom[] data;
        }
        public struct Array_0_1_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] data;
        }
        public struct Array_0_2_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] data;
        }
        public struct Array_0_13_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            public byte[] data;
        }
        public struct Array_0_3_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] data;
        }
        public struct Array_0_4_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] data;
        }
        public struct Array_0_6_byte
        {
            public byte this[int key]
            {
                get => data[key - 0];
                set => data[key - 0] = value;
            }

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] data;
        } 
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZAux_Message
        {
            public ulong TimeStamp;  // < Unix timestamp of the running PLC target in 1ms resolution 
            public String256 Text;  // < log Message as string 
            public PLC.Enums.ZCore_LogLevel LogLevel;  // < LogLevel based on [Apache log4j](https://logging.apache.org/log4j/2.x/log4j-api/apidocs/index.html) 
            public Array_0_5_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AlarmingMessageCom
        {
            public ZAux_Message Extend; 
            public String256 Source;  // < source of the alarm, usually this is the name of a unit 
            public PLC.Enums.ZApplication_AlarmingState State;  // < acknowledement state of an alarm. If acknowledment is required this can be done via [AlarmingComPublish](xref:ZApplication.AlarmingComPublish) 
            public Array_0_13_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AlarmingComPublish
        {
            public Array_0_10_ZApplication_AlarmingMessageCom Buffer; 
            public int MostSignificantIndex;  // < Index in the Buffer for the alarm with the highest priority 
            public Array_0_3_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AlarmingAcknowledge
        {
            public byte Acknowledge;  // < set to true to acknowledge the alarm 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AlarmingComSubscribe
        {
            public Array_0_10_ZApplication_AlarmingAcknowledge Buffer;  // < acknowledge an individual alarm, The index of the array has to match the index in [AlarmingComPublish](xref:ZApplication.AlarmingComPublish) 
            public byte Clear;  // < set to true to remove all acknowledged messages 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AlarmingCom
        {
            public ZApplication_AlarmingComPublish Publish;  // < contains status information of alarms, which can be read 
            public ZApplication_AlarmingComSubscribe Subscribe;  // < controls the alarming szstem, e.g. acknowledge alarms via a HMI 
            public Array_0_3_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct QuickstartComRequest
        {
            public byte Start; 
            public byte Stop; 
            public byte GoHome; 
            public byte Halt; 
            public byte MoveTransportXThrice; 
            public byte MoveBrieflyUpAction;  //  #31a24173-f7cf-4395-90ed-858a01bad4dc 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComBase
        {
            public byte Supported;  // < Is the function that the struct provides supported and implemented for this axis instance? 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComAbsolutePublish
        {
            public ZApplication_AxisComBase Extend; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComBasePublish
        {
            public ZApplication_AxisComBase Extend; 
            public String81 Name;  // < axis name according to the PLC 
            public byte Busy;  // < signals if the axis is busy or not 
            public byte Error;  // < signals if the axis is in error state or not 
            public String81 Manufacturer;  // < refers to the axis object, which is used in the PLC to control the axis (i.e. AxisPlcOpenMc) 
            public byte Simulated;  // < is the axis running in simulated mode (usually via [AxisSimulatedImpl](xref:ZEquipment.AxisSimulatedImpl)) 
            public PLC.Enums.ZEquipment_AxisSafetyStateFlags SafetyState;  // < Is there a safety feature of the drive that is currently active? 
            public PLC.Enums.ZEquipment_AxisMotionState MotionState;  // < Motion phase of the current movement 
            public String256 DriveState; 
            public byte DrivePowered;  // < is high-power available? 
            public byte DriveEnabled;  // < is the drive controlling the axis, e.g. the motor has power applied to it 
            public byte Parked;  // < is the axis disabled by software 
            public Array_0_2_byte _pad0; 
            public double ActualPosition;  // < actual position of the axis, may be 0 if the axis doesn't support positioning 
            public double ActualFollowingError;  // < actual following error, which is the deviation between the profile-generator's nominal values from ActualPosition 
            public double ActualVelocity;  // < actual velocity 
            public double ActualCurrent;  //  actual current in percent 
            public short DecimalPlacesPosition;  // < number of significant digits for ActualPosition and ActualFollowingError 
            public short DecimalPlacesVelocity;  // < number of significant digits for ActualVelocity 
            public short DecimalPlacesCurrent;  // < number of significant digits for ActualCurrent 
            public Array_0_1_byte _pad1; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComHaltPublish
        {
            public ZApplication_AxisComBase Extend; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComVelocityFeedratePublish
        {
            public ZApplication_AxisComBase Extend; 
            public Array_0_6_byte _pad0; 
            public double Feedrate;  // < actual set feedrate as value from 0.0 (0%) to 1.0 (100%) of commanded velocity 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComBrakePublish
        {
            public ZApplication_AxisComBase Extend; 
            public byte BrakeOpened;  // < Is the brake of the axis currently open or closed? 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComHomingPublish
        {
            public ZApplication_AxisComBase Extend; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComCurrentPublish
        {
            public ZApplication_AxisComBase Extend; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComVelocityPublish
        {
            public ZApplication_AxisComBase Extend; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComPositionPublish
        {
            public ZApplication_AxisComBase Extend; 
            public byte Referenced;  // < Is the axis referenced by either an absolute encoder or incremental encoder? 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComPublish
        {
            public ZApplication_AxisComAbsolutePublish Absolute;  // < Publishes actual values of [IAxisAbsolute](xref:ZEquipment.IAxisAbsolute) 
            public Array_0_6_byte _pad0; 
            public ZApplication_AxisComBasePublish Base;  // < publishes standard axis status and data like name, if it is simulated, if it is enabled or not 
            public ZApplication_AxisComHaltPublish Halt;  // < publishes a boolean which signals if the desired axis supports a standard halt or not via [IAxisHalt](xref:ZEquipment.IAxisHalt) 
            public Array_0_6_byte _pad1; 
            public ZApplication_AxisComVelocityFeedratePublish VelocityFeedrate;  // < publishes a boolean which signals if the desired axis supports a cyclic velocity feedrate or not via [IAxisVelocityFeedrate](xref:ZEquipment.IAxisVelocityFeedrate) 
            public ZApplication_AxisComBrakePublish Brake;  // < Publishes actual values of [IAxisAbsolute](xref:ZEquipment.IAxisBrake) 
            public ZApplication_AxisComHomingPublish Homing;  // < currently not publishing anything but later needed for sure to show homing status and maybe homing config  
            public ZApplication_AxisComCurrentPublish Current;  // < publishes the actual needed current by the axis for controlling the actual action  
            public ZApplication_AxisComVelocityPublish Velocity;  // < publishes the actual velocity which the axis is currently running 
            public ZApplication_AxisComPositionPublish Position;  // < publishes the actual position, following error and the configured decimal places of the axis  
            public Array_0_0_byte _pad2; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_ActuatorDigitalComPublish
        {
            public String256 Name;  // < actual name of the actuator 
            public byte Busy;  // < signals if the actuator is busy or not 
            public byte Error;  // < signals if the actuator is in error state or not 
            public byte AtMinus;  // < signals that the actuator is actually positioned on its minus position 
            public byte AtPlus;  // < signals that the actuator is actually positioned on its plus position  
            public Array_0_3_byte _pad0; 
            public double Duration;  // < duration of the actuator's last (successful and actually performed) movement in seconds 
            public String81 MinusOutputName;  // < configured name of the minus output if supported by the actual used actuator type 
            public String81 PlusOutputName;  // < configured name of the plus output if supported by the actual used actuator type 
            public String81 MinusInputName;  // < configured name of the minus input if supported by the actual used actuator type 
            public String81 PlusInputName;  // < configured name of the plus input if supported by the actual used actuator type 
            public Array_0_3_byte _pad1; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_DigitalComPublish
        {
            public String256 Name; 
            public byte Simulated; 
            public byte Writeable; 
            public byte Enabled; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct QuickstartComPublishEquipment
        {
            public ZApplication_AxisComPublish TransportX; 
            public ZApplication_ActuatorDigitalComPublish CylinderY; 
            public ZApplication_DigitalComPublish CylinderYDown; 
            public ZApplication_DigitalComPublish CylinderYUp; 
            public ZApplication_DigitalComPublish CylinderYIsDown; 
            public ZApplication_DigitalComPublish CylinderYIsUp; 
            public ZApplication_DigitalComPublish MagnetOn; 
            public ZApplication_DigitalComPublish LimitSwitchLeft; 
            public ZApplication_DigitalComPublish LimitSwitchRight; 
            public ZApplication_DigitalComPublish ConveyorOn; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct QuickstartComPublish
        {
            public PLC.Enums.ZApplication_UnitStateMachineState State;  //  state the unit is in 
            public QuickstartComRequest Request;  //  booleans that indictate which action is currently possible to perform with this unit 
            public QuickstartComPublishEquipment Equipment;  //  structs for equipment objects which are used by the bridges 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComAbsoluteSubscribe
        {
            public double Position; 
            public byte SetAbsolutePosition;  // < Used together with `SetAbsolutePosition` 
            public Array_0_6_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComBaseSubscribe
        {
            public byte EnableDrive;  // < Set to `TRUE` to perform a enabled drive action, which will apply power to the motor. The PLC automatically resets to `FALSE` 
            public byte DisableDrive;  // < Set to `TRUE` to perform a disable drive action, which will stop powering the motor. The PLC automatically resets to `FALSE` 
            public byte Stop;  // < Set to `TRUE` to perform a (fast) stop, usually this stop uses a quick-stop ramp. The PLC automatically resets to `FALSE` 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComHaltSubscribe
        {
            public byte Halt;  // < Set to `TRUE` to perform a normal stop, usually this stop uses the same profile as "normal" movements. The PLC automatically resets to `FALSE` 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComVelocityFeedrateSubscribe
        {
            public double Feedrate; 
            public byte Apply; 
            public Array_0_6_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComBrakeSubscribe
        {
            public byte OpenBrake;  // < Open the brake 
            public byte CloseBrake;  // < Close the brake  
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComHomingSubscribe
        {
            public byte Homing;  // < Set to `TRUE` to perform the axis's homing procedure. The PLC automatically resets to `FALSE` 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComVelocitySubscribe
        {
            public double Velocity; 
            public byte MoveVelocity; 
            public Array_0_6_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComPositionSubscribe
        {
            public double Speed;  // < Used together with `MoveAbsolute1`, `MoveAbsolute1`, `MoveContinuous` and `MoveRelative`  
            public double Position1; 
            public byte MoveAbsolute1;  // < Used together with `MoveAbsolute1` and `MoveContinuous` 
            public Array_0_6_byte _pad0; 
            public double Position2;  // < Used together with `MoveAbsolute2` and `MoveContinuous` 
            public byte MoveAbsolute2;  // < Set to `TRUE`` to start moving the axis to `Position2` with `Speed`. Automatically reset to `FALSE` by the PLC. 
            public Array_0_6_byte _pad1; 
            public double Delay;  // < Used together with `MoveContinuous` 
            public byte MoveContinuous;  // < Set to `TRUE`` to start moving continously from `Position1` to `Position2` (and back) with `Speed` and `Delay`. Automatically reset to `FALSE` by the PLC. 
            public Array_0_6_byte _pad2; 
            public double Distance;  // < Used together with `MoveRelative` 
            public byte MoveRelative;  // < Set to `TRUE`` to start moving to a position that is relative `distance` away from the actual position. Automatically reset to `FALSE` by the PLC. 
            public Array_0_6_byte _pad3; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_AxisComSubscribe
        {
            public ZApplication_AxisComAbsoluteSubscribe Absolute;  // < Executes commands of [IAxisAbsolute](xref:ZEquipment.IAxisAbsolute) 
            public ZApplication_AxisComBaseSubscribe Base;  // < Executes commands of [IAxisBase](xref:ZEquipment.IAxisBase) 
            public ZApplication_AxisComHaltSubscribe Halt;  // < Executes a halt command if requested provided by [IAxisHalt](xref:ZEquipment.IAxisHalt) 
            public Array_0_3_byte _pad0; 
            public ZApplication_AxisComVelocityFeedrateSubscribe VelocityFeedrate;  // < Enables one to adjust the speed of an axis between 0.0 (0%) and 1.0 (100%) by utilizing [IAxisVelocityFeedrate](xref:ZEquipment.IAxisVelocityFeedrate)  
            public ZApplication_AxisComBrakeSubscribe Brake;  // < Executes commands of [IAxisBrake](xref:ZEquipment.IAxisBrake) 
            public ZApplication_AxisComHomingSubscribe Homing;  // < Command a homing procedure of the axis  
            public Array_0_4_byte _pad1; 
            public ZApplication_AxisComVelocitySubscribe Velocity;  // < Command a velocity controlled movement of an axis if available or allowed 
            public ZApplication_AxisComPositionSubscribe Position;  // < Command a position controlled movement of an axis if available of possible 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_ActuatorDigitalComSubscribe
        {
            public byte MovePlus;  // < moves the actuator into the plus direction on a rising edge 
            public byte MoveMinus;  // < moves the actuator into the minus direction on a rising edge 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct ZApplication_DigitalComSubscribe
        {
            public byte Write; 
            public byte Enable; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct QuickstartComSubscribeEquipment
        {
            public ZApplication_AxisComSubscribe TransportX; 
            public ZApplication_ActuatorDigitalComSubscribe CylinderY; 
            public ZApplication_DigitalComSubscribe CylinderYDown; 
            public ZApplication_DigitalComSubscribe CylinderYUp; 
            public ZApplication_DigitalComSubscribe CylinderYIsDown; 
            public ZApplication_DigitalComSubscribe CylinderYIsUp; 
            public ZApplication_DigitalComSubscribe MagnetOn; 
            public ZApplication_DigitalComSubscribe LimitSwitchLeft; 
            public ZApplication_DigitalComSubscribe LimitSwitchRight; 
            public ZApplication_DigitalComSubscribe ConveyorOn; 
            public Array_0_5_byte _pad0; 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct QuickstartComSubscribe
        {
            public QuickstartComRequest Request;  //  contains booleans that are used to start a specific sequence. 
            public Array_0_1_byte _pad0; 
            public QuickstartComSubscribeEquipment Equipment;  //  structs for equipment objects which are used by the bridges 
        };
         
        [StructLayout(LayoutKind.Sequential, Pack=8)]        
        public struct QuickstartCom
        {
            public QuickstartComPublish Publish; 
            public QuickstartComSubscribe Subscribe; 
        };
        
    }
}