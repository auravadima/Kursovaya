using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using CefSharp;
using CefSharp.WinForms;
using System.IO;
using System.Threading;

namespace Kursach
{
    public partial class MainForm : Form
    {
        static ChromiumWebBrowser browser;
     
        static string SQLS =
            @"Data Source = DESKTOP-E2QV49A\SQLEXPRESS;Initial Catalog=terrorism; Integrated Security=SSPI;";

        private readonly SqlConnection _sqlConnection = new SqlConnection(SQLS);


        public MainForm()
        {
            InitializeComponent();
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            browser = new ChromiumWebBrowser("file://" + Path.GetDirectoryName(Application.ExecutablePath) + "/map.html");
            mapTab.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            tabControl.SelectTab(2);
        }

        private void Browser_IsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            tabControl.Invoke((MethodInvoker)delegate ()
           {
               tabControl.SelectTab(0);
           });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _sqlConnection.Open();
        }

        private void GetResultTable()
        {
            try
            {
                var adapter = new SqlDataAdapter($"SELECT * FROM GetAll() {GetCondition()}", _sqlConnection);
                var table = new DataTable();
                adapter.Fill(table);
                mainGrid.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private string GetCondition()
        {
            string condition = "where";

            condition += $" Region like '%{regionText.Text}%' " +
                $"and Country like '%{countryText.Text}%' " +
                $"and City like '%{cityText.Text}%' " +
                $"and WeaponType like '%{weaponText.Text}%' " +
                $"and TargetType like '%{targetTypeText.Text}%' " +
                $"and Target like '%{targetText.Text}%'";

            condition += yearCheck.Checked ? $" and Year = {yearNumeric.Value}" : "";
            condition += monthCheck.Checked ? $" and Month = {monthNumeric.Value}" : "";
            condition += dayCheck.Checked ? $" and Day = {dayNumeric.Value}" : "";

            condition += killCheck.Checked ? $" and Killed = {killNumeric.Value}" : "";
            condition += woundCheck.Checked ? $" and Wounded = {woundNumeric.Value}" : "";
            condition += successCheck.Checked ? isSuccess.Checked ? " and Success = 1" : " and Success = 0" : "";

            if (keyWordCheck.Checked)
            {
                var words = keyWordText.Text.Split(',');
                if(words.Length > 0)
                {
                    condition += " and";
                    for (var i = 0; i < words.Length - 1; i++)
                    {
                        condition += $" Summary like '%{words[i]}%' or Notes like  '%{words[i]}%' or";
                    }
                    condition += $" Summary like '%{words[words.Length - 1]}%' or Notes like  '%{words[words.Length - 1]}%'";
                }
            }

            return condition;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            GetResultTable();
            tabControl.SelectTab(1);
            new Thread(() =>
            {
                WebPageProcessor.CreateMap(mainGrid);
                browser.Reload();
            }).Start();
        }
    }
}