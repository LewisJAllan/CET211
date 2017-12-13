using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace AssignmentLewis_John_AllanCET211
{
    public partial class Form1 : Form
    {
        //create new objects into classes and subclasses
        /// <summary>
        /// An array to pass into a new User object
        /// </summary>
        User userAdd;

        //create a generic list to hold all users in
        UserList users = new UserList();       

        //create a filename variable with file name and type
        const String FILENAME = "User.dat";

        //create a Filestream for an outfile to write to and an infile to read from
        FileStream outFile;
        FileStream inFile;

        //create a BinaryFormatter to be able to deserialize the data types written in the file
        BinaryFormatter bFormatter = new BinaryFormatter();
         
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Create a dummy login for testing
            userAdd = new User("LewisAllan", "LewisA", "lewisallan");
            //create variables for storing information
            Boolean bool1 = false;
            string username = txtHasUsername.Text;
            string password = txtHasPassword.Text;
            
            //Run function for deserializing
            ReadFromFile();
            //Find user that is logging in
            User test = users.FindItem(username);
            while (bool1 == false)
            {
                try
                {
                    if (txtHasUsername.Text == "" || txtHasPassword.Text == "")
                    {
                        EnterFieldsException fields = new EnterFieldsException();
                        throw (fields);
                        
                    }
                    else
                    {
                        Boolean bool2;
                        //Check this user has entered correct login details
                        bool2 = test.CheckLogin(username, password);
                        if (bool2 == true)
                        {
                            using (StreamWriter sw = new StreamWriter("CurrentUser.txt"))
                            {
                                sw.WriteLine(users.FindItem(username));
                            }

                            BookingForm frm2 = new BookingForm();
                            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                            this.Hide();
                            frm2.Show();
                            bool1 = true;

                        }
                        else
                        {
                            MessageBox.Show("Wrong details");
                            bool1 = true;
                        }
                    }
                    bool1 = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "error");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "error");
                    outFile.Close();
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");
                    bool1 = true;
                }
            }      
        }

        public void ReadFromFile()
        {
            
            // open file for input
            inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);

            // keep going while there are still records to read
            while (inFile.Position < inFile.Length)
            {
                // obtain object from file via serialization
                User userT = (User)bFormatter.Deserialize(inFile);
                //add items to list
                users.Users.Add(userT);
            }

            //close file
            inFile.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //create variables for storing information 
            string sName;
            string sUsername;
            string sPassword;
            bool bDetails = false;

            sName = txtName.Text;
            sUsername = txtNewUsername.Text;
            sPassword = txtNewPassword.Text;

            //create an array to save new user details
            User newUser;

            //check all relevant information is filled in
            while (bDetails != true)
            {
                //check for any possible user errors
                try
                {
                    if (txtName.Text == "" || txtNewUsername.Text == "" || txtNewPassword.Text == "")
                    {
                        EnterFieldsException fields = new EnterFieldsException();
                        throw (fields);
                    }
                    //Check this user can be added            
                    users.AddUser(newUser = new User(sName, sUsername, sPassword));

                    // open file for output
                    outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);

                    // output object to file via serialization
                    bFormatter.Serialize(outFile, newUser);

                    // close file
                    outFile.Close();

                    using (StreamWriter sw = new StreamWriter("CurrentUser.txt"))
                    {
                        sw.WriteLine(sUsername);
                    }

                    BookingForm frm2 = new BookingForm();
                    frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                    this.Hide();
                    frm2.Show();

                    bDetails = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "error");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "error");
                    outFile.Close();
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");
                    bDetails = true;
                }
            }
            
            
        }

        public void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
