#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.Alarm;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        DigitalAlarm1 = Project.Current.Get<DigitalAlarm>("Alarms/DigitalAlarm1");
        DigitalAlarm1.UAEvent += DigitalAlarm1_UAEvent;

        ExclusiveLevelAlarm1 = Project.Current.Get<ExclusiveLevelAlarmController>("Alarms/ExclusiveLevelAlarm1");
        ExclusiveLevelAlarm1.UAEvent += ExclusiveLevelAlarm1_UAEvent;

        ExclusiveDeviationAlarm1 = Project.Current.Get<ExclusiveDeviationAlarmController>("Alarms/ExclusiveDeviationAlarm1");
        ExclusiveDeviationAlarm1.UAEvent += ExclusiveDeviationAlarm1_UAEvent;

        ExclusiveRateOfChangeAlarm1 = Project.Current.Get<ExclusiveRateOfChangeAlarmController>("Alarms/ExclusiveRateOfChangeAlarm1");
        ExclusiveRateOfChangeAlarm1.UAEvent += ExclusiveRateOfChangeAlarm1_UAEvent;

        NonExclusiveLevelAlarm1 = Project.Current.Get<NonExclusiveLevelAlarmController>("Alarms/NonExclusiveLevelAlarm1");
        NonExclusiveLevelAlarm1.UAEvent += NonExclusiveLevelAlarm1_UAEvent;

        NonExclusiveDeviationAlarm1 = Project.Current.Get<NonExclusiveDeviationAlarmController>("Alarms/NonExclusiveDeviationAlarm1");
        NonExclusiveDeviationAlarm1.UAEvent += NonExclusiveDeviationAlarm1_UAEvent;

        NonExclusiveRateOfChangeAlarm1 = Project.Current.Get<NonExclusiveRateOfChangeAlarmController>("Alarms/NonExclusiveRateOfChangeAlarm1");
        NonExclusiveRateOfChangeAlarm1.UAEvent += NonExclusiveRateOfChangeAlarm1_UAEvent;
    }

    private void DigitalAlarm1_UAEvent(object sender, UAEventArgs e)
    {
        DigitalAlarm alarm = (DigitalAlarm)sender;
        Log.Info("Message: " + alarm.Message + ", Variable: " + e.Arguments.GetArgument("SourceName").ToString() + ", Alarm: " + e.Arguments.GetArgument("ConditionName").ToString());
    }

    private void ExclusiveLevelAlarm1_UAEvent(object sender, UAEventArgs e)
    {
        ExclusiveLevelAlarmController alarm = (ExclusiveLevelAlarmController)sender;
        Log.Info("Message: " + alarm.Message + ", Variable: " + e.Arguments.GetArgument("SourceName").ToString() + ", Alarm: " + e.Arguments.GetArgument("ConditionName").ToString());
    }

    private void ExclusiveDeviationAlarm1_UAEvent(object sender, UAEventArgs e)
    {
        ExclusiveDeviationAlarmController alarm = (ExclusiveDeviationAlarmController)sender;
        Log.Info("Message: " + alarm.Message + ", Variable: " + e.Arguments.GetArgument("SourceName").ToString() + ", Alarm: " + e.Arguments.GetArgument("ConditionName").ToString());
    }

    private void ExclusiveRateOfChangeAlarm1_UAEvent(object sender, UAEventArgs e)
    {
        ExclusiveRateOfChangeAlarmController alarm = (ExclusiveRateOfChangeAlarmController)sender;
        Log.Info("Message: " + alarm.Message + ", Variable: " + e.Arguments.GetArgument("SourceName").ToString() + ", Alarm: " + e.Arguments.GetArgument("ConditionName").ToString());
    }

    private void NonExclusiveLevelAlarm1_UAEvent(object sender, UAEventArgs e)
    {
        NonExclusiveLevelAlarmController alarm = (NonExclusiveLevelAlarmController)sender;
        Log.Info("Message: " + alarm.Message + ", Variable: " + e.Arguments.GetArgument("SourceName").ToString() + ", Alarm: " + e.Arguments.GetArgument("ConditionName").ToString());
    }

    private void NonExclusiveDeviationAlarm1_UAEvent(object sender, UAEventArgs e)
    {
        NonExclusiveDeviationAlarmController alarm = (NonExclusiveDeviationAlarmController)sender;
        Log.Info("Message: " + alarm.Message + ", Variable: " + e.Arguments.GetArgument("SourceName").ToString() + ", Alarm: " + e.Arguments.GetArgument("ConditionName").ToString());
    }

    private void NonExclusiveRateOfChangeAlarm1_UAEvent(object sender, UAEventArgs e)
    {
        NonExclusiveRateOfChangeAlarmController alarm = (NonExclusiveRateOfChangeAlarmController)sender;
        Log.Info("Message: " + alarm.Message + ", Variable: " + e.Arguments.GetArgument("SourceName").ToString() + ", Alarm: " + e.Arguments.GetArgument("ConditionName").ToString());
    }

    public override void Stop()
    {
        DigitalAlarm1.UAEvent -= DigitalAlarm1_UAEvent;
        ExclusiveLevelAlarm1.UAEvent -= ExclusiveLevelAlarm1_UAEvent;
        ExclusiveDeviationAlarm1.UAEvent -= ExclusiveDeviationAlarm1_UAEvent;
        ExclusiveRateOfChangeAlarm1.UAEvent -= ExclusiveRateOfChangeAlarm1_UAEvent;
        NonExclusiveLevelAlarm1.UAEvent -= NonExclusiveLevelAlarm1_UAEvent;
        NonExclusiveDeviationAlarm1.UAEvent -= NonExclusiveDeviationAlarm1_UAEvent;
        NonExclusiveRateOfChangeAlarm1.UAEvent -= NonExclusiveRateOfChangeAlarm1_UAEvent;
    }

    private DigitalAlarm DigitalAlarm1;
    private ExclusiveLevelAlarmController ExclusiveLevelAlarm1;
    private ExclusiveDeviationAlarmController ExclusiveDeviationAlarm1;
    private ExclusiveRateOfChangeAlarmController ExclusiveRateOfChangeAlarm1;
    private NonExclusiveLevelAlarmController NonExclusiveLevelAlarm1;
    private NonExclusiveDeviationAlarmController NonExclusiveDeviationAlarm1;
    private NonExclusiveRateOfChangeAlarmController NonExclusiveRateOfChangeAlarm1;
}

