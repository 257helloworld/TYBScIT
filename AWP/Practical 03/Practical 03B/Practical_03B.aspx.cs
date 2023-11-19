using System;
using System.Drawing;
using System.Web.UI.WebControls;

namespace Practical_03B
{
    public partial class Practical_03B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string DateToday = DateTime.Now.ToShortDateString();
            Result1.Text = "Today's Date: " + DateToday;
        } 
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            // 5th Oct - International Teacher's Day.
            if(e.Day.Date.Day == 5 && e.Day.Date.Month == 10)
            {
                Label lb = new Label();
                lb.Text = "<br/>International Teacher's Day";
                e.Cell.Controls.Add(lb);
                e.Cell.BackColor = Color.AliceBlue;
            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Result2.Text = "Selected Date: " + Calendar1.SelectedDate.ToShortDateString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan difference = Calendar2.SelectedDate - Calendar1.SelectedDate;
            Result3.Text = "Difference: " + difference.Days + " days.";
        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.Date.Day == 28 && e.Day.Date.Month == 11)
            {
                Calendar2.SelectedDate = new DateTime(2023, 11, 28);
                Calendar2.SelectedDates.SelectRange(Calendar2.SelectedDate, Calendar2.SelectedDate.AddDays(5));
                Label lb = new Label();
                lb.Text = "<br/>Winter Vacation";
                e.Cell.Controls.Add(lb);
            }
        }
    }
}