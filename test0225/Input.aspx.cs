using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test0225.Manager;
using test0225.Models;

namespace test0225
{
    public partial class Input : System.Web.UI.Page
    {
        private TestContentManager _mgr = new TestContentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            if (!this.CheckInput()) // 是否通過檢查
                return;

            string basenumber = this.txtBaseNumber.Text.Trim();
            string coeffnumber = this.txtCoefficientNumber.Text.Trim();


            int basenumberint = 0;
            int coeffnubmerint = 0;
            TestContent model = new TestContent();
            if (int.TryParse(basenumber, out basenumberint))
            {
                model.BaseNumber = basenumberint;
            }
            else
                model.BaseNumber = 0;
            if (int.TryParse(coeffnumber, out coeffnubmerint))
            {
                model.CoefficientNumber = coeffnubmerint;
            }
            else
                model.CoefficientNumber = 0;


            _mgr.CreateTestContent(model);

            for (int i = 0; i < basenumberint; i++)
            {
                Literal literalmono = new Literal();
                literalmono.ID = $"{i + 1}";
                string tableText = $"<table border='1' cellspacing='0' class='p'><tr><th>基數{i + 1}</th>";

                for (int j = 0; j < coeffnubmerint; j++)
                {
                    tableText += $"</tr><tr><td>{i + 1} * {j + 1} = {(i + 1) * (j + 1)}</td></tr>";
                }
                literalmono.Text = tableText;
                this.panel1.Controls.Add(literalmono);
            }

        }
        public bool CheckInput()
        {
            List<string> msgList = new List<string>();

            string basenumber = this.txtBaseNumber.Text.Trim();
            string coeffnumber = this.txtCoefficientNumber.Text.Trim();

            int basenumberint = 0;
            int coeffnubmerint = 0;
            if (!int.TryParse(basenumber, out basenumberint))
            {
                if (basenumberint < 1 || basenumberint > 15)
                    msgList.Add("基數必須介於 1 ~ 15的正整數");
            }
            if (!int.TryParse(coeffnumber, out coeffnubmerint))
            {
                if (coeffnubmerint < 1 || coeffnubmerint > 15)
                    msgList.Add("係數必須介於 1 ~ 15的正整數");
            }
            if (msgList.Count > 0)
            {
                string allError = string.Join("<br/>", msgList);
                this.ltlMessage.Text = allError;
                return false;
            }
            return true;
        }
    }
}