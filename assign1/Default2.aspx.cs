using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToString("MM/dd/yyyy");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {  
        //checkBoxList
        int chkCount = 0;

        for (int x = 0; x < CheckBoxList1.Items.Count; x++)
        {
            if (CheckBoxList1.Items[x].Selected)
                chkCount++;
        }


        if (chkCount > 0)
        {
            Label2.Text = " ";
            for (int i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    Label2.Text += CheckBoxList1.Items[i].Value + " ";
                }
            }
        }
        else
        {
            Label2.Text = "Label2";
        }
        


        //RadioButton

        if (TextBox1.Text.Length == 0)
        {   
            if (RadioButton1.Checked == true)
            {
                Label3.Text = "Label3";
            }
            else if (RadioButton2.Checked == true)
            {
                Label3.Text = "Label3";
            }
            else if (RadioButton3.Checked == true)
            {
                Label3.Text = "Label3";
            }
            else
            {
                Label3.Text = "Label3";
            }

        }

        else if (TextBox1.Text.Length < 2)
        {
            if (RadioButton1.Checked == true)
            {
                Label3.Text = "Label3";
            }
            else if (RadioButton2.Checked == true)
            {
                Label3.Text = "Label3";
            }
            else if (RadioButton3.Checked == true)
            {
                Label3.Text = "Label3";
            }
            else
            {
                Label3.Text = TextBox1.Text;
            }
        }

        else if (TextBox1.Text.Length >= 2)
        {
            double inputValue = Convert.ToDouble(TextBox1.Text);

            if (RadioButton1.Checked == true)
            {
                Label3.Text = (inputValue / 2).ToString();
            }
            else if (RadioButton2.Checked == true)
            {
                Label3.Text = (inputValue * 2).ToString();
            }
            else if (RadioButton3.Checked == true)
            {
                Label3.Text = (inputValue *3).ToString();
            }
            else
            {
                Label3.Text = TextBox1.Text;
            }
        }

    }

 
}


