using System.Text;

namespace Final_Project_OOP.Parking
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "เช็คอิน";
            dataGridView1.Rows[n].Cells[1].Value = textBoxName.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxNumber.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBoxEmail.Text;
            dataGridView1.Rows[n].Cells[4].Value = dateTimePicker2.Text; 
            dataGridView1.Rows[n].Cells[5].Value = label4.Text; 
            dataGridView1.Rows[n].Cells[6].Value = textBoxRoom.Text;
        
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "เช็คเอาท์";
            dataGridView1.Rows[n].Cells[1].Value = textBoxName.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxNumber.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBoxEmail.Text;
            dataGridView1.Rows[n].Cells[4].Value = dateTimePicker2.Text;
            dataGridView1.Rows[n].Cells[5].Value = label4.Text;
            dataGridView1.Rows[n].Cells[6].Value = textBoxRoom.Text;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            checkBox1.Checked= false;
            checkBox2.Checked= false;
            checkBox3.Checked= false;
            checkBox4.Checked= false;
            checkBox5.Checked= false;
            checkBox6.Checked= false;
            checkBox7.Checked= false;
            checkBox8.Checked= false;
            checkBox9.Checked= false;
            checkBox10.Checked= false;
            checkBox11.Checked= false;
            checkBox12.Checked= false;
            checkBox13.Checked= false;
            checkBox14.Checked= false;
            checkBox15.Checked= false;
            checkBox16.Checked= false;
            checkBox17.Checked= false;
            checkBox18.Checked= false;
            checkBox19.Checked= false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;



            textBoxName.Text = "";
            textBoxNumber.Text = "";
            textBoxEmail.Text = "";
            textBoxRoom.Text = "";
            
            

        }

        private void btpay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
            this.Hide();
           
        }

        

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";

                        }
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";

                            }

                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortTimeString();
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxRoom.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.textBoxRoom.Text != "")
                            this.textBoxRoom.Text = this.textBoxRoom.Text + ", ";

                        this.textBoxRoom.Text += ((CheckBox)control).Text;
                    }
                }
            }

        }

      
    }

}