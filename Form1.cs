using Amazon.S3;
using Amazon.S3.Transfer;
using FirebirdSql.Data.FirebirdClient;
using MP_Tool.Constants;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            Style();
            chkSingle.Visible = false;
            chkMulti.Visible = false;
            rbtnFoxProDB.Checked = true;

            this.grdSunixQuery.DataError += this.grdSunixQuery_DataError;


        }


        void grdSunixQuery_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                //lblrowsEffected.Visible = true;
                Cursor.Current = Cursors.WaitCursor;
                string sql = "";
                if (!string.IsNullOrEmpty(txtQuery.SelectedText))
                {
                    sql = txtQuery.SelectedText;
                    //txtQuery.SelectionColor = Color.Green;
                }
                else
                {
                    sql = txtQuery.Text;

                }

                string con = txtConn.Text;
                DataTable dt = new DataTable();

                var watch = System.Diagnostics.Stopwatch.StartNew();

                if (rbtnNexusDb.Checked)
                {
                    dt = TestDirectOptomateNexusConnection(con, sql);
                }
                else if (rbtnFoxProDB.Checked)
                {
                    dt = TestDirectSunixConnection(con, sql);
                }
                else if (rbtnSqlServerDB.Checked)
                {
                    dt = SQLSERVERCon(con, sql);
                }
                else if (rFireBirdDB.Checked)
                {
                    dt = FireBirdDBConn(con, sql);
                }
                else if (rbInterBaseDB.Checked)
                {
                    dt = InterBaseDBConn(con, sql);
                }
                watch.Stop();

                grdSunixQuery.DataSource = dt;
                Cursor.Current = Cursors.Default;
                lblrowsEffected.Text = $"{dt.Rows.Count} {"row(s) effected "}";
                lblQueryExecutionTime.Text = $"Query Execution Time : {watch.ElapsedMilliseconds}ms";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        public DataTable InterBaseDBConn(string con, string sql)
        {
            DataTable dTable = new DataTable();
            try
            {
                using (var conn = new OdbcConnection(con))
                {
                    string maxNumberQuery = sql;//"SET PASSWORDS ADD '6!6@6#5$3%9';SELECT MAX(NUMBER) FROM CLIENT";
                                                  //string maxNumberQuery = "SELECT MAX(Duration) FROM AppointSetup";
                    OdbcCommand oCmd = new OdbcCommand(maxNumberQuery, conn);
                    conn.Open();
                    var dataReader = oCmd.ExecuteReader();
                    dTable.Load(dataReader);
                }
                return dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dTable;
            }
        }

        public DataTable TestDirectSunixConnection(string connStr, string sql)
        {

            DataTable dtCustomers = new DataTable("");
            try
            {
                using (var conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, conn);


                    var dataReader = cmd.ExecuteReader();

                    dtCustomers.Load(dataReader);
                }

                return dtCustomers;
            }
            catch
            {
                throw;
            }
        }


        public static DataTable TestDirectOptomateNexusConnection(string connection, string query)
        {
            // connection = "DRIVER={NexusDB V3.09 Driver};Transport=TCP;SERVER=NexusDB@10.0.109.34;PORT=16000;DataBase=Premier;";
            DataTable dtOptomate = new DataTable("");
            try
            {
                using (var conn = new OdbcConnection(connection))
                {
                    string maxNumberQuery = query;//"SET PASSWORDS ADD '6!6@6#5$3%9';SELECT MAX(NUMBER) FROM CLIENT";
                                                  //string maxNumberQuery = "SELECT MAX(Duration) FROM AppointSetup";
                    OdbcCommand oCmd = new OdbcCommand(maxNumberQuery, conn);
                    conn.Open();
                    var dataReader = oCmd.ExecuteReader();
                    dtOptomate.Load(dataReader);
                }
                return dtOptomate;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public static DataTable SQLSERVERCon(string connection, string query)
        {
            DataTable dtOptomate = new DataTable("SQLSERVER");
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connection))
                {
                    SqlCommand oCmd = new SqlCommand(query, myConnection);
                    myConnection.Open();
                    var dataReader = oCmd.ExecuteReader();
                    dtOptomate.Load(dataReader);
                }
                return dtOptomate;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static DataTable FireBirdDBConn(string connectionString, string query)
        {
            DataTable dTable = new DataTable();
            try
            {
                var ZedMedDBConn = new FbConnection(connectionString);
                ZedMedDBConn.Open();
                using (FbConnection myconn = new FbConnection(connectionString))
                {
                    FbCommand oCmd = new FbCommand(query, myconn);
                    myconn.Open();
                    var dataReader = oCmd.ExecuteReader();
                    dTable.Load(dataReader);
                }
                return dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dTable;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // txtQuery.Clear();
            grdSunixQuery.DataSource = null;
        }

        private void RSunixDb_CheckedChanged(object sender, EventArgs e)
        {
            chkSingle.Visible = true;
            chkMulti.Visible = true;

            rbtnNexusDb.ForeColor = Color.Black;
            rbtnSqlServerDB.ForeColor = Color.Black;
            rbtnFoxProDB.ForeColor = Color.Green;

            chkMulti.ForeColor = Color.Black;
            chkSingle.ForeColor = Color.Black;
            rFireBirdDB.ForeColor = Color.Black;
            rbInterBaseDB.ForeColor = Color.Black;


            txtConn.Text = "";
        }

        private void rOptomteDb_CheckedChanged(object sender, EventArgs e)
        {
            chkMulti.Checked = false;
            chkSingle.Checked = false;

            chkSingle.Visible = true;
            chkMulti.Visible = true;

            rbtnSqlServerDB.ForeColor = Color.Black;
            rbtnFoxProDB.ForeColor = Color.Black;
            rbtnNexusDb.ForeColor = Color.Green;
            rFireBirdDB.ForeColor = Color.Black;

            chkMulti.ForeColor = Color.Black;
            chkSingle.ForeColor = Color.Black;
            rbInterBaseDB.ForeColor = Color.Black;

            txtConn.Text = "";
        }

        private void rbtnSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            chkSingle.Visible = false;
            chkMulti.Visible = false;

            chkMulti.Checked = false;
            chkSingle.Checked = false;

            rbtnNexusDb.ForeColor = Color.Black;
            rbtnSqlServerDB.ForeColor = Color.Green;
            rbtnFoxProDB.ForeColor = Color.Black;
            rFireBirdDB.ForeColor = Color.Black;
            rbInterBaseDB.ForeColor = Color.Black;

            txtConn.Text = @"";
        }

        private void check_FireBirdDB_CheckedChanged(object sender, EventArgs e)
        {
            rbtnNexusDb.ForeColor = Color.Black;
            rbtnSqlServerDB.ForeColor = Color.Black;
            rbtnFoxProDB.ForeColor = Color.Black;
            rFireBirdDB.ForeColor = Color.Green;
            rbInterBaseDB.ForeColor = Color.Black;
            txtConn.Text = @"";
        }
        private void rbInterBaseDB_CheckedChanged(object sender, EventArgs e)
        {
            rbtnNexusDb.ForeColor = Color.Black;
            rbtnSqlServerDB.ForeColor = Color.Black;
            rbtnFoxProDB.ForeColor = Color.Black;
            rFireBirdDB.ForeColor = Color.Green;
            rbInterBaseDB.ForeColor = Color.Black;
            txtConn.Text = @"";
        }

        private void rbntSinle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMulti_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSingle_CheckedChanged(object sender, EventArgs e)
        {
            chkMulti.Checked = false;
            chkMulti.ForeColor = Color.Black;
            chkSingle.ForeColor = Color.Green;

            if (rbtnNexusDb.Checked)
                txtConn.Text = "";

            else if (rbtnFoxProDB.Checked)
                txtConn.Text = "";

            if (chkSingle.Checked == false)
                txtConn.Clear();
        }

        private void chkMulti_CheckedChanged(object sender, EventArgs e)
        {
            chkSingle.Checked = false;
            chkSingle.ForeColor = Color.Black;
            chkMulti.ForeColor = Color.Green;

            if (rbtnNexusDb.Checked)
                txtConn.Text = "";

            else if (rbtnFoxProDB.Checked)
                txtConn.Text = "";

            if (chkMulti.Checked == false)
                txtConn.Clear();
        }

        #region Query Commander


        private void btnStart_Click_1(object sender, EventArgs e)
        {
            rchtxtOutput.Clear();
            string cmd = "aws ec2 start-instances --instance-ids ";
            //string Instance = txtInsatnceId.Text;
            if (!string.IsNullOrEmpty(txtInsatnceId.Text))
            {
                Instance instance = new Instance();
                rchtxtOutput.Text += ExecuteCommand($"{cmd}{txtInsatnceId.Text}", instance);
            }
            foreach (var instance in GetInstances())
            {
                rchtxtOutput.Text += ExecuteCommand($"{cmd}{instance.VMInstanceId}", instance);
                MarkColorForSelectedVMS(Color.Green, false);

                DialogResult res = MessageBox.Show($"{"Are you sure you want to Open VM"} {"'"}{instance.VMName}{"'"}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    LoadRemoteConnection(instance);
                }
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            rchtxtOutput.Clear();
            string cmd = "aws ec2 stop-instances --instance-ids ";
            //string Instance = txtInsatnceId.Text;

            if (!string.IsNullOrEmpty(txtInsatnceId.Text))
            {
                Instance instance = new Instance();
                rchtxtOutput.Text += ExecuteCommand($"{cmd}{txtInsatnceId.Text}", instance);
            }

            foreach (var instance in GetInstances())
            {
                rchtxtOutput.Text += ExecuteCommand($"{cmd}{instance.VMInstanceId}", instance);
                MarkColorForSelectedVMS(Color.Black, false);
            }
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            rchtxtOutput.Clear();
            string cmd = "aws ec2 stop-instances --instance-ids ";
            //string Instance = txtInsatnceId.Text;

            if (!string.IsNullOrEmpty(txtInsatnceId.Text))
            {
                Instance instance = new Instance();
                rchtxtOutput.Text += ExecuteCommand($"{cmd}{txtInsatnceId.Text}", instance);
            }

            foreach (var instance in GetInstances(true))
            {
                rchtxtOutput.Text += ExecuteCommand($"{cmd}{instance.VMInstanceId}", instance);
                MarkColorForSelectedVMS(Color.Black, false);
            }
        }

        private string ExecuteCommand(string command, Instance instance = null)
        {


            StringBuilder output = new StringBuilder();
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;
            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();
            output.Append(command + "  " + Environment.NewLine);
            output.Append(process.StandardOutput.ReadToEnd());
            string error = process.StandardError.ReadToEnd();

            if (!string.IsNullOrWhiteSpace(error))
            {
                output.Append($"{"ERROR: "} {error}");
            }
            exitCode = process.ExitCode;
            output.Append($"{"EXITCODE: "}{ exitCode}" + Environment.NewLine);
            var vmName = instance != null ? instance.VMName : "";
            var vmIP = instance != null ? instance.VMIP : "";
            var vmInstance = instance != null ? instance.VMInstanceId : "";
            output.Append($"{"VM Name::::::::: "} { vmName }" + Environment.NewLine);
            output.Append($"{"VM IP::::::::::: "}{ vmIP}" + Environment.NewLine);
            output.Append($"{"VM Instance::::: "}{ vmInstance}" + Environment.NewLine);
            output.Append($"{"_______________________________________________________________________________________"}{Environment.NewLine}{Environment.NewLine}");
            process.Close();

            return output.ToString();
        }



        private void LoadRemoteConnection(Instance instance)
        {
            Process rdcProcess = new Process();

            string executable = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
            if (executable != null)
            {
                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                // rdcProcess.StartInfo.Arguments = $"{"/generic:TERMSRV/"}{instance.VMIP} {"/ user:"}{txtVMuserName.Text}{" /pass:"}{txtVMPwd.Text}";

                rdcProcess.StartInfo.FileName = executable;
                rdcProcess.StartInfo.Arguments = "/v " + instance.VMIP;  // ip or name of computer to connect
                rdcProcess.Start();
            }
        }

        private void MarkColorForSelectedVMS(Color forecClr, bool Ischecked = false)
        {

        }

        public List<Instance> GetInstances(bool stopall = false)
        {
            List<Instance> instances = new List<Instance>();
            return instances;
        }


        private void Style()
        {

            var font = new Font("arial", 10);

            chkdevsyncchs.Font = font;
        }

        private void btnFetchServices_Click(object sender, EventArgs e)
        {
            var sss = GetAllServices();
        }


        public void stopService(string ServiceName)
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = ServiceName;

            //Console.WriteLine("The {0} service status is currently set to {1}", ServiceName, sc.Status.ToString());

            if (sc.Status == ServiceControllerStatus.Running)
            {
                // Start the service if the current status is stopped.
                //Console.WriteLine("Stopping the {0} service ...", ServiceName);
                try
                {
                    // Start the service, and wait until its status is "Running".
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);

                    // Display the current service status.
                    MessageBox.Show($"The {ServiceName} service status is now set to {sc.Status.ToString()}.");
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show("Could not stop the {0} service.", ServiceName);
                }
            }
            else
            {
                MessageBox.Show("Cannot stop service {0} because it's already inactive.", ServiceName);
            }
        }

        public void startService(string ServiceName)
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = ServiceName;

            Console.WriteLine("The {0} service status is currently set to {1}", ServiceName, sc.Status.ToString());

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                // Start the service if the current status is stopped.
                Console.WriteLine("Starting the {0} service ...", ServiceName);
                try
                {
                    // Start the service, and wait until its status is "Running".
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);

                    // Display the current service status.
                    Console.WriteLine("The {0} service status is now set to {1}.", ServiceName, sc.Status.ToString());
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Could not start the {0} service.", ServiceName);
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Service {0} already running.", ServiceName);
            }
        }

        public bool serviceIsRunning(string ServiceName)
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = ServiceName;

            if (sc.Status == ServiceControllerStatus.Running)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ServiceController[] scServices;

        List<Services> services = new List<Services>();
        private List<Services> GetAllServices()
        {
            scServices = ServiceController.GetServices();

            // Display the list of services currently running on this computer.

            foreach (ServiceController scTemp in scServices)
            {
                Services service = new Services();
                service.ServiceName = scTemp.ServiceName;
                service.ServiceDes = scTemp.DisplayName;
                if (scTemp.Status == ServiceControllerStatus.Running)
                {
                    service.IsRuning = true;
                    services.Add(service);
                }
                else
                {
                    service.IsRuning = false;
                    services.Add(service);
                }
            }
            //var ss =services?.Where(x => x.ServiceName.Contains("")?).ToList();
            return services?.Where(x => x.ServiceDes.Contains(""))?.ToList();
        }


        string tempFileFullPath = "";
        private void btndwnFile_Click(object sender, EventArgs e)
        {
            try
            {
                TransferUtility fileTransferUtility =
                new TransferUtility(
                new AmazonS3Client("", "", Amazon.RegionEndpoint.APSoutheast2));
                string bucketName = tbBucketName.Text;
                string fileKey = tbFileKey.Text;
                string fileName = fileKey.Split('/').Last();
                tempFileFullPath = Path.GetTempPath() + fileName;
                // Note the 'fileName' is the 'key' of the object in S3 (which is usually just the file name)
                fileTransferUtility.Download(tempFileFullPath, bucketName, fileKey);
                //rtxtFileData.Text = $"The file is downloaded at below path {tempFileFullPath}.";
                lnkFile.Text = tempFileFullPath;
                BindDataToTextBox();
            }

            catch (Exception ex)
            {
                rtxtFileData.Text = $"Error Occured during the file download.Error details:{ex.ToString()}.";
            }
        }

        private void btnCheckDotNetVersion_Click(object sender, EventArgs e)
        {
            lnkFile.Text = "File Name";
            // Opens the registry key for the .NET Framework entry.
            using (RegistryKey ndpKey =
                RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").
                OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                // As an alternative, if you know the computers you will query are running .NET Framework 4.5 
                // or later, you can use:
                // using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, 
                // RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {

                        RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                        string name = (string)versionKey.GetValue("Version", "");
                        string sp = versionKey.GetValue("SP", "").ToString();
                        string install = versionKey.GetValue("Install", "").ToString();
                        if (install == "") //no install info, must be later.
                            richTextBox2.Text += Environment.NewLine + versionKeyName + "  " + name;
                        else
                        {
                            if (sp != "" && install == "1")
                            {
                                richTextBox2.Text += Environment.NewLine + versionKeyName + "  " + name + "  SP" + sp;
                            }

                        }
                        if (name != "")
                        {
                            continue;
                        }
                        foreach (string subKeyName in versionKey.GetSubKeyNames())
                        {
                            RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                            name = (string)subKey.GetValue("Version", "");
                            if (name != "")
                                sp = subKey.GetValue("SP", "").ToString();
                            install = subKey.GetValue("Install", "").ToString();
                            if (install == "") //no install info, must be later.
                                richTextBox2.Text += Environment.NewLine + versionKeyName + "  " + name;
                            else
                            {
                                if (sp != "" && install == "1")
                                {
                                    richTextBox2.Text += Environment.NewLine + "  " + subKeyName + "  " + name + "  SP" + sp;
                                }
                                else if (install == "1")
                                {
                                    richTextBox2.Text += Environment.NewLine + "  " + subKeyName + "  " + name;
                                }
                            }
                        }
                    }
                }
            }
        }

        public List<string> LoadCsvFile()
        {
            List<string> searchList = new List<string>();
            if (!string.IsNullOrEmpty(tempFileFullPath))
            {
                var reader = new StreamReader(File.OpenRead(tempFileFullPath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    searchList.Add(line);
                }
            }
            return searchList;
        }

        private void BindDataToTextBox()
        {
            rtxtFileData.Text = "";
            var fileData = LoadCsvFile();
            int count = 0;
            foreach (var data in fileData)
            {
                rtxtFileData.Text += data + Environment.NewLine;
                count++;
                lblpatientCount.Text = $"Patient(s) Count:{count}";
            }
        }
        private void lnkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BindDataToTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnRun_Click(null, null);
        }

        private void rEasyRecall_CheckedChanged(object sender, EventArgs e)
        {
            rAlconReminders.Checked = false;
            tbBucketName.Text = "";
        }

        private void rAlconReminders_CheckedChanged(object sender, EventArgs e)
        {
            rEasyRecall.Checked = false;
            tbBucketName.Text = "";
        }
    }

    public class Services
    {
        public string ServiceName { get; set; }
        public string ServiceDes { get; set; }
        public bool IsRuning { get; set; }
    }
    #endregion
}

