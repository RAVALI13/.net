using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace Asg2_rxn152730
{
    public partial class Form1 : Form
    {
        int ListViewItemTag = 0;
        private int sortColumn = -1;
        public Form1()
        {
            InitializeComponent();
        }

        //-------------NESTED CLASS-----------------------------------
        //-------------ListViewItemComparer : IComparer ------------
       class ListViewItemComparer:IComparer
        {
            private int col;
            private SortOrder order;
           //----------ListViewItemComparer--------------------

           public ListViewItemComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }
           //-------------List View ItemComparer2------------
           public ListViewItemComparer(int column, SortOrder order)
           {
               col = column;
               this.order = order;
           }
           //-------------Compare-------------------
           public int Compare(object x, object y)
           {
               int returnVal;
               //Compare the 2 items as a string
               returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
               //Determine whether the sort order is descending
               if(order == SortOrder.Descending)
                   //Invert the value returned by String.Compare 
                   returnVal *= -1;
                   return returnVal;               
           }
       } //----NESTED CLASS CLOSE -----------



         //---------------To display the updated values in listview1 when add, modify & Delete ------
       void RefreshData()
       {
            //To clear the entire listview 
            listView1.Items.Clear();
        
            string curFile = "CS6326Asg2.txt";
            ListViewItemTag = 0;

            if (System.IO.File.Exists(curFile))
            {
                System.IO.StreamReader file = new System.IO.StreamReader("CS6326Asg2.txt", true);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] items = line.Split('\t');

                    //to hold name and phone subitems
                    string[] itemsToAdd = new string[2];
                    
                    //Concatinating the first, last & middle name into Name subitem
                    itemsToAdd[0] = items[1]+" "+items[2]+ " " +items[3];
                    
                    //Phone value into phone number subitem
                    itemsToAdd[1] = items[9];

                    ListViewItem lv = new ListViewItem(itemsToAdd);
                    listView1.Items.Add(lv);

                    lv.Tag = items[0];
                    ListViewItemTag = Convert.ToInt32(items[0]);
                }
                
                //incrementing the tag for next new data
                ListViewItemTag++;
                file.Close();
            }
        }    


        //------------------Form Load------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //Disable the save button
            button1.Enabled = false;

            //Today's date is set by default
            dateTimePicker1.Value = DateTime.Today;

            //Updating the listview1 with latest data
            RefreshData();

            //To set the screen appear on the center when application is run
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.CenterToScreen();
        }

              
        //-------------------------Save Button Operations--------------------
        private void button1_Click(object sender, EventArgs e) 
        {
           string line;
           int check = 0;   //Variable to check if the Name exists in the existing data

           string entered_name = FirstNameBox.Text + " " + LastNameBox.Text + " " + MiddleInitialBox.Text;
           
            System.IO.StreamReader file = new System.IO.StreamReader("CS6326Asg2.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] items = line.Split('\t');
                string name = items[1] + " " + items[2] + " " + items[3];
                
                //To compare if the entered name and name in file are same
                if (String.Compare(name, 0, entered_name, 0, 5, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        check = 1;
                        break;
                    }
            }
            file.Close();

            //If the names are same, then disable the save button and prompt error msg
            if (check == 1 && (toolStripStatusLabel1.Text.Equals("New Data")))
            {
                button1.Enabled = false;
                errorProvider1.SetError(FirstNameBox, "Name already exists");
            }
            
             //---------To apply changes into records (MODIFY) ---------------
            else if (listView1.SelectedItems.Count > 0)
            {
                errorProvider1.Clear();
                string tagToCompare = listView1.SelectedItems[0].Tag.ToString();
                string[] lines = File.ReadAllLines("CS6326Asg2.txt");
                int totalNumberOfLines = lines.Length;

                for (int indexOfLines = 0; indexOfLines < totalNumberOfLines; ++indexOfLines)
                {
                    string lineToSplit = lines[indexOfLines];
                    string[] ArrayOfLine = lineToSplit.Split('\t');

                    if (tagToCompare == ArrayOfLine[0])
                    {
                        ListViewItemTag = Convert.ToInt32(tagToCompare);
                        Modify(Convert.ToInt32(tagToCompare));
                    }
                }

                //To update the strip status value
                toolStripStatusLabel1.Text = "New Data";
                statusStrip1.Refresh();
               
                RefreshData(); 
                ClearAllText(this);
              
            }

            // If New Record has to be added.
            else
            {
                errorProvider1.Clear();
                System.IO.StreamWriter FileToWriteTo = new System.IO.StreamWriter("CS6326Asg2.txt", true);
                
                FileToWriteTo.WriteLine(SaveData(ListViewItemTag));
                FileToWriteTo.Close();
                RefreshData(); 
                ClearAllText(this);
            }       
        }

        string SaveData(int TagToAppend)
        {
            string RadioButtonValue;

            if (radioButton1.Checked)
                RadioButtonValue = "Yes";
            else
                RadioButtonValue = "No";
            
            string theDate = dateTimePicker1.Value.ToShortDateString();
            
            string data = String.Join("\t", TagToAppend, FirstNameBox.Text, LastNameBox.Text, MiddleInitialBox.Text, AddressLine1Box.Text, AddressLine2Box.Text, CityBox.Text, StateBox.Text, ZipCodeBox.Text, PhoneNumberBox.Text, EmailIdBox.Text, RadioButtonValue, theDate);
            return data;
        }

        //------------Code to modify the contents in the text file--------
        void Modify(int tagToInsert)
        {
            string[] lines = File.ReadAllLines("CS6326Asg2.txt");
            int totalNumberOfLines = lines.Length;
            //loc var to keep track of line that needs to be modified
            //check var to store status of the name if it already exists.
            int loc = 0, check = 0;
            
            string entered_name = FirstNameBox.Text + " " + LastNameBox.Text + " " + MiddleInitialBox.Text;
            for (int indexOfLines = 0; indexOfLines < totalNumberOfLines; indexOfLines++)
            {
                string lineToSplit = lines[indexOfLines];
                string[] line = lineToSplit.Split('\t');
                string name = line[1] + " " + line[2] + " " + line[3];
                if (tagToInsert != Convert.ToInt32(line[0]))
                {
                    if (String.Compare(name, 0, entered_name, 0, 5, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        check = 1;
                        break;
                    }
                }
                
                else if (tagToInsert == Convert.ToInt32(line[0]))
                {
                    loc = indexOfLines;
                }
            }

            if (check == 0)
            {
                lines[loc] = SaveData(tagToInsert);
                button1.Enabled = true;
                errorProvider1.Clear();
            }
            else
            {
                button1.Enabled = false;
                errorProvider1.SetError(FirstNameBox, "Existing Name");
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter("CS6326Asg2.txt", false);

            for (int indexOfLines = 0; indexOfLines < totalNumberOfLines; indexOfLines++)
            {
                string lineToSplit = lines[indexOfLines];
                string[] line = lineToSplit.Split('\t');
                string lineToInsert = String.Join("\t", line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[8], line[9], line[10], line[11], line[12]);
                file.WriteLine(lineToInsert);
            }
            file.Close();

        }

        //To clear all the values in textboxes
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
                dateTimePicker1.Value = DateTime.Today;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        //----------------CLEAR BUTTON ------------------------------
        private void button3_Click(object sender, EventArgs e) 
        {
            toolStripStatusLabel1.Text = "New Data";
            statusStrip1.Refresh();

            dateTimePicker1.Value = DateTime.Today;
            ClearAllText(this);
            errorProvider1.Clear();
        }

        //Checks if the user left the value of textbox blank
        void checkEmptyText()
        {
            Regex reg = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            if (!string.IsNullOrEmpty(FirstNameBox.Text) && reg.IsMatch(EmailIdBox.Text) && !string.IsNullOrEmpty(LastNameBox.Text) && !string.IsNullOrEmpty(StateBox.Text) && !string.IsNullOrEmpty(CityBox.Text) && !string.IsNullOrEmpty(AddressLine1Box.Text) && !string.IsNullOrEmpty(EmailIdBox.Text) && (radioButton1.Checked || radioButton2.Checked))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        //-------------------------DELETE BUTTON----------------------
        private void button2_Click(object sender, EventArgs e) 
        {
           
            //To fetch the tag of the selected item
            string tagToCompare = listView1.SelectedItems[0].Tag.ToString();

            //Removing the item associated with the selected tag
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

            //To read all the lines in a file into an array
            string[] lines = File.ReadAllLines("CS6326Asg2.txt");

            //using Total number of indices in the array to find the num of lines in file
            int totalNumberOfLines = lines.Length;

            //For each value in array index 
            for (int indexOfLines = 0; indexOfLines < totalNumberOfLines; ++indexOfLines)
            {

                string lineToSplit = lines[indexOfLines];
               
                //to split the string into items
                string[] line = lineToSplit.Split('\t');
                int temp = indexOfLines + 1;
                
                //Searching for the record we wanted to delete  
                if (tagToCompare == line[0])
                {
                    int additional_temp = indexOfLines + 1;
                    int current_temp = indexOfLines;

                    while (current_temp < totalNumberOfLines - 1)
                    {
                        lines[current_temp] = lines[additional_temp];
                        additional_temp++;
                        current_temp++;
                    }
                    break;
                }
                ClearAllText(this);
                dateTimePicker1.Value = DateTime.Today;

            }
            //To write the lines back into file after deletion
            System.IO.StreamWriter file = new System.IO.StreamWriter("CS6326Asg2.txt", false);

            for (int indexOfLines = 0; indexOfLines < totalNumberOfLines - 1; ++indexOfLines)
            {
                string lineToSplit = lines[indexOfLines];
                string[] line = lineToSplit.Split('\t');
                //joining the splitted tokens into a string and to write into file
                string lineToInsert = String.Join("\t", line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[8], line[9], line[10], line[11], line[12]);
                file.WriteLine(lineToInsert);
            }

            file.Close();
        }

        //To display the selected items in the listview into textboxes
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //To check if the selected listview items has values in it
            if (listView1.SelectedItems.Count > 0)
            {
                toolStripStatusLabel1.Text = "Modify Data";
                statusStrip1.Refresh();

                ListViewItem item = listView1.SelectedItems[0];
                string[] lines = File.ReadAllLines("CS6326Asg2.txt");
                for (int indexOfLines = 0; indexOfLines < lines.Length; ++indexOfLines)
                {
                    string lineToSplit = lines[indexOfLines];
                    string[] line = lineToSplit.Split('\t');

                    //searches for the selected tag in the file and checks if it matches
                    if (line[0] == listView1.SelectedItems[0].Tag.ToString())
                    {
                        //Displays values into textboxes
                        FirstNameBox.Text = line[1];
                        LastNameBox.Text = line[2];
                        MiddleInitialBox.Text = line[3];
                        AddressLine1Box.Text = line[4];
                        AddressLine2Box.Text = line[5];
                        CityBox.Text = line[6];
                        StateBox.Text = line[7];
                        ZipCodeBox.Text = line[8];
                        PhoneNumberBox.Text = line[9];
                        EmailIdBox.Text = line[10];
                        if (line[11] == "Yes")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }

                        dateTimePicker1.Value = DateTime.Parse(line[12]);
                    }
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "New Data";
                statusStrip1.Refresh();
                ClearAllText(this);
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        //---------TO SORT THE VALUES IN LISTVIEWITEM1---------------
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
          //Determine whether the column is the same as the last column clicked
           if(e.Column != sortColumn)
            {
               //set the sort column to the selected column
                sortColumn = e.Column;
               //Set the order to ascending by default
                listView1.Sorting = SortOrder.Ascending;
            }
            else{
               //Determine what the last sort order was and change it
                if(listView1.Sorting == SortOrder.Ascending)
                    listView1.Sorting = SortOrder.Descending;
                else
                    listView1.Sorting = SortOrder.Ascending;

            }
            listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
          
      }

        //------------------VALIDATIONS--------------------------------

      private void FirstNameBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();


      }

      private void LastNameBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void MiddleInitialBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void AddressLine1Box_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void AddressLine2Box_TextChanged(object sender, EventArgs e)
      {
         checkEmptyText();
      }

      private void CityBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void StateBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void ZipCodeBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void EmailIdBox_TextChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }
      
        //To check if the emailid entered follows a specific format  eq., abcd@domain.com
        private void EmailIdBox_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"); ///Object initialization for Regex 
            if (reg.IsMatch(EmailIdBox.Text))
            {
                 errorProvider1.Clear();
             }
          else
          {

              errorProvider1.SetError(EmailIdBox, "Invaild email");
          }
      }
        
      private void listView1_KeyPress(object sender, KeyPressEventArgs e)
      {
          if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
          {
              e.Handled = true;
          }
      }
        //To check if the phone number entered is only digits and it accepts + if entered by user at the begining

      private void PhoneNumberBox_Leave(object sender, EventArgs e)
      {
          Regex reg = new Regex(@"^(\+[0-9])$");

          if ((PhoneNumberBox.Text.Length > 6))
          {
              if (Regex.Match(PhoneNumberBox.Text, @"^(\+?[0-9]*)$").Success)
              {
                  errorProvider1.Clear();
              }
              else
              {
                  errorProvider1.SetError(PhoneNumberBox, "Invalid Phone number");
              }
          }
          else
          {
              errorProvider1.SetError(PhoneNumberBox, "Phone number too short");
          }
      }

      private void PhoneNumberBox_KeyPress(object sender, KeyPressEventArgs e)
      {
          if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '+'))
          {
              e.Handled = true;
          }
      }

        //Validation for zip code
      private void ZipCodeBox_Leave(object sender, EventArgs e)
      {
          if (ZipCodeBox.Text.Length == 5 || ZipCodeBox.Text.Length == 10)
          {
              errorProvider1.Clear();
          }
          else
          {
              errorProvider1.SetError(ZipCodeBox, "Zip code not valid ");
          }
      }
        //Validation for State
      private void StateBox_KeyPress(object sender, KeyPressEventArgs e)
      {
          if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
          {
              e.Handled = true;
          }
      }

      private void StateBox_Leave(object sender, EventArgs e)
      {
          if (StateBox.Text.Length > 1)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(StateBox, "Too Short");
            }
        }

      private void CityBox_KeyPress(object sender, KeyPressEventArgs e)
      {
          if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
          {
              e.Handled = true;
          }
      }

      private void radioButton1_CheckedChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void radioButton2_CheckedChanged(object sender, EventArgs e)
      {
          checkEmptyText();
      }

      private void ZipCodeBox_KeyPress(object sender, KeyPressEventArgs e)
      {
          if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
          {
              e.Handled = true;
          }
      }

      

      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
      {
          dateTimePicker1.MaxDate = DateTime.Today;
      }

      private void button4_Click(object sender, EventArgs e)
      {
          RefreshData();
      }
      private void label1_Click(object sender, EventArgs e)
      {

      }
      private void label3_Click(object sender, EventArgs e)
      {

      }
          }

        }

    

