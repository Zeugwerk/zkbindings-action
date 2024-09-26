/* Generated code */
using System;

namespace PLC
{
    namespace Enums
    {
    
        // size = 2B
        public enum ZCore_LogLevel : short
        {
            Undefined = 0,// < unused, uninitialized
            Trace = 1,// < *Zeugwerk Framework* diagnostic messages, this level is reserved for use libraries
            Debug = 2,// < detailed information about key method parameters or other information that is useful for finding likely problems in specific 'problematic' areas of the code
            Info = 3,// < diagnostic messages in production (step changes, method calls, ...)
            Warning = 4,// < errors in sequences that are unusual, but the machine can deal with at least semi-automatically
            Error = 5,// < sequence error that stop the machine from working properly (axes fault, actuator timeouts, invalid data ...)
            Fatal = 6,// < hardware failures, booting sequence failures
            Off = 7// < used to switch off log messages completely when setting a [log-level filter](xref:ZCore.ILoggerBase#MinimumLevel)
        };

    
        // size = 2B
        public enum ZApplication_AlarmingState : short
        {
            Undefined = 0,
            Incoming = 1,// < an alarm was issued by the PLC
            IncomingAcknowledged = 2,// < the incoming alarm has been acknowledged by an operator or a trigger
            Outgoing = 4,// < the reason why the alarm was issued by the PLC is gone
            OutgoingAcknowledged = 8,// < the disappearance of the alarm reason is acknowledged by the operator or a trigger
            Done = 15// < no user interaction required
        };

    
        // size = 2B
        public enum ZApplication_UnitStateMachineState : short
        {
            Undefined = 0,// < Zero is no valid state and therefore undefined
            Boot = 1,// < Active state: initial state of a unit. It is executed during startup and can also be executed later if necessary to do a reinitialization
            BootFault = 2,// < Inactive state: If booting (e.g. startup) fails, this is indicated by this state; possible errors can be a missing for example connection to a fieldbus or faulty initialization
            Init = 3,// < Inactive state: this state is set after booting succeeded, this means the unit is ready for use but needs proper homing
            Idle = 4,// < Inactive state: signals that the unit is ready for use
            Stopped = 5,// < Inactive state: signals to a statemachine that it has been stopped and the *stop sequence* has been executed
            Fault = 6,// < Inactive state: if anything caused an error in an unit (usually an equipment instance inside the *automatic sequence* or the *homing sequence*) the statemachine takes care of executing a faultreaction and subsequently transitions into the fault state.
            GoHome = 7,// < Active state: brings the unit from an init or faulty state into a *ready for use* environment 
            Stop = 8,// < Active state: stops the unit by executing the *stop sequence* 
            FaultReaction = 9,// < Active state: reacts to a fault which happens during idle, automatic or goHome state. When the fault reaction is done, the unit is put into it Fault state.
            Automatic = 10,// < Active state: controls the actual process of the unit
            Halt = 11,// < Special Active state: indicates that a previously active state currently reacts to a halt request, see [CancellationToken](xref:ZCore.CancellationToken)
            Halted = 12// < Special Inactive state: indicates that a previously active state reacted successfully to a halt request and the sequence configured a milestone to resume from, see [CancellationToken](xref:ZCore.CancellationToken) 
        };

    
        // size = 2B
        public enum ZEquipment_AxisMotionState : short
        {
            Undefined = 0,//  The axis is in an undefined motion state; This state is mostly set by the drive itself if it is for example in booting procedure
            Standstill = 1,//  The axis is currently standing still or at least the drive is not actively trying to move the axis. The consideration of external forces is usually not considered here.
            Accelerating = 2,//  The axis is accelerating towards the constant velocity phase. However, depending on the motion profile the latter phase may not be reachable, because of a jerk limit of acceleration limit.
            Decelerating = 3,//  The axis is decelerating toward zero velocity (e.g. stillstand).
            ConstantVelocity = 4//  The axis is moving with constant velocity, either endlessly or towards a target position. Depending on the motion profile, which is used for the movement this motion state may not be reached and instead Accelerating changes seamlessly to Decelerating.
        };

    
        // size = 2B
        public enum ZEquipment_AxisSafetyStateFlags : short
        {
            SafeStateOk = 0,//  No Safety State diagnosed, axis safe to use
            SafeTorqueOff = 1,//  STO: The power supply to the motor is cut by the drive. If the motor is in motion it will spin down in an uncontrolled way. As soon as the power os cut the motor can not produce torque also not for braking.
            SafeStop1 = 2,//  SS1: The power supply to the motor is cut by the drive. If the motor is in motion it spins down in a "controlled" way. This is achieved by activating the STO only after a fixed duration or by controlling the standstill of the motor in a given window.
            SafeStop2 = 4,//  SS2: The motor is held in position by the drive with a given torque or force. If the motor is in motion it spins down in a controlled way and once 0 velocity is reached the drive will try to keep to motor in position. The position of the motor is monitored. If it moves out of the predefined positon-monitoring window the power is cut by the drive by activating the safe-torque off feature.
            SafeOperatingStop = 8,//  SOS: The drive monitors if the current position of the motor is held. If the motor moves out of this position, the drive cuts the power to it by activing the safe-torque off feature.
            SafeLimitedSpeed = 16,//  SLS: The drive monitors if the velocity of the motor is below a predefined maximum velocity and can trigger a predefined error reaction of the speed gets above this level.
            SafeSpeedMonitor = 32,//  SSM: The drive monitors if the velocity of the motor is below a predefined minimum velocity and can trigger a predefined error reaction of the speed gets underneath this level.
            SafeSpeedRange = 64,//  SSR: Combintation of SafeLimitedSpeed (SLS) and SafeSpeedMonitor (SSM).
            SafeLimitedPosition = 128,//  SLP: If this safety feature is active, the drive monitors if the motor is not moving out of predefined limits.
            SafePosition = 256,//  SP: If this safety featurs is active, the drive is submitting position data redunantly, which can be used by a safety control system.
            SafeDirectionPositive = 512,//  SDI: If this safety feature is active the drive is only allowed to move in the positive direction (in a safe way).
            SafeDirectionNegative = 1024,//  SDI: If this safety feature is active the drive is only allowed to move in the negative direction (in a safe way). 
            SafeBrakeControl = 2048,//  SBC: SafeBrakeControl is usually used together with the SafeBrakeTest (SBT). SBC is controlling one or more (external) to ensure that the load is not moving after a STO command. Usually SBC and SBT are cyclically enabled by the drive (if the feature is supported and activated) to ensure that the brake is still working as expected or if maintainance is required.
            SafeBrakeTest = 4096
        };

    
    }
}
