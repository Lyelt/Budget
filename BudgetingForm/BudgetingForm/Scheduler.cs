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
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Runs daily to determine whether there are any expenses to record";
                td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
                td.Actions.Add(new ExecAction("RecordExpenses.exe"));
                ts.RootFolder.RegisterTaskDefinition("ExpenseTask", td);
            }
        }
    }
}
