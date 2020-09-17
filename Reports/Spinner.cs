using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public static class Spinner
    {
        public static async Task ShowSpinner(Form form,Task task)
        {
            var spinner = new cSpinner();
            spinner.Height = 150;
            spinner.Width = 150;
            spinner.Name = "spinner";
            form.Controls.Add(spinner);
            spinner.Left = (form.ClientSize.Width - spinner.Width) / 2;
            spinner.Top = (form.ClientSize.Height - spinner.Height) / 2;
            spinner.BringToFront();
            form.Controls[spinner.Name].BringToFront();
            form.Enabled = false;
            await task;
            if (task.IsCompleted)
            {
                form.Controls.Remove(spinner);
                form.Enabled = true;
            }
        }
        public static void ShowSpinnerNonAsync(Form form, Action task)
        {
            var spinner = new cSpinner();
            spinner.Height = 150;
            spinner.Width = 150;
            spinner.Name = "spinner";
            form.Controls.Add(spinner);
            spinner.Left = (form.ClientSize.Width - spinner.Width) / 2;
            spinner.Top = (form.ClientSize.Height - spinner.Height) / 2;
            spinner.BringToFront();
            form.Controls[spinner.Name].BringToFront();
            form.Enabled = false;
            task();

            form.Controls.Remove(spinner);
            form.Enabled = true;
        }
    }
}
