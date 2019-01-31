using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;



namespace VAPESHOP
{
    public partial class aftorizat : Form
    {

        // XML_CODE _logpass = new XML_CODE(); // code tyt xml
        XML_CODE _logpass = null;
        public string USID;
        public string ISA;
        public string ALA;
        public string EOA;
        public string MA;
        public string PRA;
        public aftorizat()
        {
            InitializeComponent();
            _logpass = XML_CODE.GetSetting();    // code tyt xml
            _initControls();


        }

        public void _initControls()
        {


            //login.Text = _logpass.savelog;


            //password.Text = _logpass.savepass;
        }

        //-----------------------------------------------------
        //Объекты для аутентификации пользователей
        public TextBox Login_Text = new TextBox();
        public Label Login_Label = new Label();
        public TextBox Pass_Text = new TextBox();
        public Label Pass_Label = new Label();
        public Button Button_Enter = new Button();
        public Button Button_Register = new Button();
        //-----------------------------------------------------
        //Объекты для подключения к источнику данных
        public ComboBox Server_CB = new ComboBox();
        public ComboBox DataBase_CB = new ComboBox();
        public Label Base_Login_Label = new Label();
        public TextBox Base_Login_Text = new TextBox();
        public Label Base_Password_Label = new Label();
        public TextBox Base_Password_Text = new TextBox();
        public Button Check_Connection_Button = new Button();
        public Button Connect_Data_Source_Button = new Button();
        //-----------------------------------------------------
        //Объекты формы регистрации
        public Form Registration_Window = new Form();
        public Label New_Login_Label = new Label();
        public Label New_Password_Label = new Label();
        public Label Conform_Password_Label = new Label();
        public Label Count_Login_Char_Label = new Label();
        public Label Count_Password_Char_Label = new Label();
        public TextBox New_Login_Text = new TextBox();
        public TextBox New_Password_Text = new TextBox();
        public TextBox Conform_Password_Text = new TextBox();
        public Button Registrate_Button = new Button();
        public Button Cancel_Button = new Button();
        public int Log_Count = 16;
        public int Pass_Count = 16;
        void SelectDBCB_MouseCapture(object sender, MouseEventArgs e)
        {
            //try connect.close()
            try
            {


                SqlConnection Try_Connect = new SqlConnection();
                Try_Connect.ConnectionString = "Data Source=" + Server_CB.Text
                    + ", Initial Catalog=master; Persist Security Info = true; User ID="
                    + Base_Login_Text.Text + ";Password=\"" + Pass_Text + "\"";
                Try_Connect.Open();
                SqlDataAdapter Base_Adapter = new SqlDataAdapter("exec sp_helpdb ", Try_Connect);
                DataSet Base_Data_Set = new DataSet();
                Base_Adapter.Fill(Base_Data_Set, "db");
                DataBase_CB.DataSource = Base_Data_Set.Tables[0].DefaultView;
                DataBase_CB.DisplayMember = "name";
                Try_Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // при нажатии на кнопку, скрывается панель регистрации
        private void button3_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }
        //при загрузки формы, у нас подключалась база 
        //данных и настройка видимости панели регистрации и авторизации
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string sdwConnectionString = @"Data Source = 193.124.112.29,1433\SERVER; user id=Midas; password=1488228228q; Initial Catalog = PlayToPlay;";

                // Create a connection
                SqlConnection sdwDBConnection = new SqlConnection(sdwConnectionString);

                // Open the connection
                sdwDBConnection.Open();
                label8.Text = "Подключен к Источнику Данных";
            }
            catch
            {
              label8.Text = ("Не удалось подключмтся к Источнику Данных");
            }

        }
        //Vhod v programmu
        private void aftor_Click(object sender, EventArgs e)
        {
            try
            {
                if (login.Text == "ADMIN" && password.Text == "ADMIN")
                {
                    MenuForm2121 sad = new MenuForm2121();
                    sad.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR LOG AND PAS");
                }

            }
            catch
            {
                MessageBox.Show("ошибка программы");
            }
        }
    }
}

       
           


       
    
  
   


