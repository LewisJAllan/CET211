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
    public partial class UserAccount : Form
    {
        //create a filename variable with file name and type
        const String FILENAME = "User.dat";

        //create a Filestream for an outfile to write to and an infile to read from
        FileStream outFile;
        FileStream inFile;

        //create a BinaryFormatter to be able to deserialize the data types written in the file
        BinaryFormatter bFormatter = new BinaryFormatter();

        //create a generic list to hold all users in
        UserList users = new UserList();

        string username;
        User user;

        public UserAccount()
        {
            InitializeComponent();
        }

        public string CurrentUser()
        {
            using (StreamReader sr = new StreamReader("CurrentUser.txt"))
            {
                while (sr.Peek() != -1)
                {
                    username = sr.ReadLine();
                }
                return username;
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
        private void UserAccount_Load(object sender, EventArgs e)
        {
            CurrentUser();
            ReadFromFile();
            //Find the current user
            username = CurrentUser();
            user = users.FindItem(username);

            lblUser.Text = user.ToString() + ", " + user.Name;
            lblRunTotal.Text = user.ShowTotal();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.Pay());
            // open file for output
            outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);

            // output object to file via serialization
            bFormatter.Serialize(outFile, user);

            // close file
            outFile.Close();

            //clear label with old total
            lblRunTotal.Text = user.ShowTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
