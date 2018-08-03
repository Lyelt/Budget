using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;

namespace BudgetingForm
{
    public static class Scheduler
    {
        public static void SetDailyTask()
        {
            var log = LyeltLogger.LogManager.GetGlobalLogger();
            try
            {
                using (TaskService ts = new TaskService())
                {
                    if (ts.FindTask("ExpenseTask") == null)
                    {
                        TaskDefinition td = ts.NewTask();
                        td.RegistrationInfo.Description = "Runs daily to determine whether there are any expenses to record";
                        td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
                        td.Actions.Add(new ExecAction("RecordExpenses.exe"));
                        td.Settings.StartWhenAvailable = true;
                        ts.RootFolder.RegisterTaskDefinition("ExpenseTask", td);
                        log.Information("Adding daily task to run RecordExpenses.exe");
                    }
                    else
                    {
                        log.Information("ExpenseTask already exists");
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
    }
}
