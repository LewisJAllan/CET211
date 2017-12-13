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
    public partial class BookingForm : Form
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

        /// <summary>
        /// An object of BoxingClass
        /// </summary>
        BoxingClass boxing1 = new BoxingClass("Sunderland");
        /// <summary>
        /// An object of YogaClass
        /// </summary>
        YogaClass[] yoga1 = new YogaClass[1];
        /// <summary>
        /// An object of Gym
        /// </summary>
        Gym[] newcastle = new Gym[1];
        /// <summary>
        /// An object of Gym
        /// </summary>
        Gym[] washington = new Gym[1];
        /// <summary>
        /// An object of GymWithPool
        /// </summary>
        GymWithPool[] sunderland = new GymWithPool[1];
        /// <summary>
        /// An object of GymWithPool
        /// </summary>
        GymWithPool[] durham = new GymWithPool[1];
        /// <summary>
        /// An object of PersonalTrainer
        /// </summary>
        PersonalTrainer[] PT = new PersonalTrainer[4];

        string username;
        User user;
        int iindex;
        List<PersonalTrainer> pt = new List<PersonalTrainer>();
        //create enumerator to step through list
        IEnumerator<PersonalTrainer> en;
        

        public BookingForm()
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

        private void BookingForm_Load(object sender, EventArgs e)
        {
            CurrentUser();
            ReadFromFile();
            //Pass in details for objects of classes
            yoga1[0] = new YogaClass("Sunderland");
            newcastle[0] = new Gym("Newcastle");
            washington[0] = new Gym("Washington");
            sunderland[0] = new GymWithPool("Sunderland");
            durham[0] = new GymWithPool("Durham");
            PT[0] = new PersonalTrainer("Lewis", "Sunderland", 50);
            PT[1] = new PersonalTrainer("Glenn", "Newcastle", 10);
            PT[2] = new PersonalTrainer("John", "Durham", 30);
            PT[3] = new PersonalTrainer("Shannon", "Washington", 25);
            //Find the current user
            username = CurrentUser();
            user = users.FindItem(username);
            //Put the Personal Trainers in a generic list so that they can be
            //organised alphabetically
            
            pt.Add(PT[0]);
            pt.Add(PT[1]);
            pt.Add(PT[2]);
            pt.Add(PT[3]);
            pt.Sort();

            en = pt.GetEnumerator();
            while (en.MoveNext())
            {
                //populate the combo box
                cboPT.Items.Add(en.Current);                
            }
        }
        //function to write new data to file for when moving between forms
        public void AddBooking()
        {
            // open file for output
            outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);

            // output object to file via serialization
            bFormatter.Serialize(outFile, user);

            // close file
            outFile.Close();
        }

        private void btnGym_Click(object sender, EventArgs e)
        {
                      
            //make sure all radio buttons are selected
            if (rdoHiddenGym.Checked == true)
            {
                MessageBox.Show("Please make sure you have selected a gym before proceeding to book one");
            }
            else if(rdoNewcastle.Checked == true)
            {
                
                //show user the string message the method creates
                MessageBox.Show(user.BookItem(newcastle[0]));
                //Add the string message to the list to show the user what they have booked
                lstBooked.Items.Add(user.SessionType(newcastle[0]));
                //run the method through the function to serialize it
                AddBooking();
            }
            else if(rdoDurham.Checked == true)
            {
                
                MessageBox.Show(user.BookItem(durham[0]));
                lstBooked.Items.Add(user.SessionType(durham[0]));
                AddBooking();
            }
            else if(rdoWashington.Checked == true)
            {
                MessageBox.Show(user.BookItem(washington[0]));
                lstBooked.Items.Add(user.SessionType(washington[0]));
                AddBooking();
            }
            else if(rdoSunderland.Checked == true)
            {
                MessageBox.Show(user.BookItem(sunderland[0]));
                lstBooked.Items.Add(user.SessionType(sunderland[0]));
                AddBooking();
            }
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            //make sure all radio buttons are selected
            if (rdoHiddenClass.Checked == true)
            {
                MessageBox.Show("Please make sure you have selected a class before proceeding to book one");
            }
            else if (rdoYoga.Checked == true)
            {
                //show user the string message the method creates
                MessageBox.Show(user.BookItem(yoga1[0]));
                //Add the string message to the list to show the user what they have booked
                lstBooked.Items.Add(user.SessionType(yoga1[0]));
                //run the method through the function to serialize it
                AddBooking();
            }
            else if (rdoBoxing.Checked == true)
            {
                MessageBox.Show(user.BookItem(boxing1));
                lstBooked.Items.Add(user.SessionType(boxing1));
                AddBooking();
            }
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            //check the user has selected a personal trainer
            if (cboPT.SelectedIndex > -1)
            {

                //inform system of who they have booked and inform the user if it has been successful               
                //due to the sort method, find which array this links with (terrible way to do it but do not know how to make it simpler)
                if(cboPT.SelectedItem == PT[0])
                {                    
                    iindex = 0;
                }
                else if(cboPT.SelectedItem == PT[1])
                {
                    iindex = 1;
                }
                else if (cboPT.SelectedItem == PT[2])
                {
                    iindex = 2;
                }
                else if (cboPT.SelectedItem == PT[3])
                {
                    iindex = 3;
                }
                MessageBox.Show(user.BookItem(PT[iindex]));
                lstBooked.Items.Add(user.SessionType(PT[iindex]));
                AddBooking();
            }
            else
            {
                //error message for user
                MessageBox.Show("Please select a personal trainer before proceeding");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UserAccount frm2 = new UserAccount();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            this.Hide();
            frm2.Show();
        }
        public void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
