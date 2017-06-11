using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;  // Added
using System.IO;
using System.Timers;


namespace _1542037_RUN_PACKAGE_FORM
{
    public partial class frmExecPackageSSIS : Form
    {
        public frmExecPackageSSIS()
        {
            InitializeComponent();
        }

        private string var_info_log;
        private string var_info_log_sort;
        private string url_packages;
        private void btnBrowser1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();
            ////fileDialog.Filter = "txt files (*.dtsx)|*.dtsx|All files (*.*)|*.*";
            //fileDialog.Filter = "txt files (*.dtsx)|*.dtsx";
            //fileDialog.FilterIndex = 2;
            //fileDialog.RestoreDirectory = true;

            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txtPathPackage.Text = fileDialog.FileName;
            //}

            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPathPackage.Text = folderDialog.SelectedPath;
                }
            }
        }
        private void btnBrowser2_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtImportFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        String scan_file_in_directory (string dir_path)
        {
            try
            {
                var directory = new DirectoryInfo(dir_path);
                var myFile = (from f in directory.GetFiles() orderby f.LastWriteTime descending select f).First();
                return myFile.Name.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                //set path folder import files .
                string path = txtImportFolder.Text;
                string path_package = txtPathPackage.Text;

                //scan file in directory realtime ----------------
                string file_scan_directory_realtime = scan_file_in_directory(path);

                if (file_scan_directory_realtime != null)
                {
                    var_info_log = var_info_log + "Time: " + DateTime.Now.ToString() + " - ";
                    var_info_log = var_info_log + "File: " + file_scan_directory_realtime + "\n";
                    var_info_log = var_info_log + "-----------------------------------------------------------------------------------------------------------------------------------------------------------\n";

                    // Instantiate SSIS application object
                    Microsoft.SqlServer.Dts.Runtime.Application myApplication = new Microsoft.SqlServer.Dts.Runtime.Application();

                    // Load package from file system (use LoadFromSqlServer for SQL Server based packages)
                    var_info_log = var_info_log + "Loading package from file system." + "\n";
                    txtShowLogs.Text = var_info_log;


                    if (file_scan_directory_realtime.ToUpper().Contains("OWNER") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "OWNER.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("BRANCH") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "BRANCH.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("CUSTOMER") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "CUSTOMER.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("ACCOUNT") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "ACCOUNT.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("ACCOUNT-TYPE") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "ACCOUNT-TYPE.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("EMPLOYEE") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "EMPLOYEE.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("POSITION-EMP") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "POSITION-EMP.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("SAVINGS-ACCOUNT") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "SAVINGS-ACCOUNT.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("TRANSACTION") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "TRANSACTION.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("TRANSACTION-TYPES") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "TRANSACTION-TYPES.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("TYPE-SAVINGS-ACCOUNT") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "TYPE-SAVINGS-ACCOUNT.dtsx");
                    }
                    else if (file_scan_directory_realtime.ToUpper().Contains("SAVINGS-ACCOUNT") == true)
                    {
                        url_packages = System.IO.Path.Combine(path_package, "SAVINGS-ACCOUNT.dtsx");
                    }
                    else
                    {
                        url_packages = null;
                    };

                    //Package myPackage = myApplication.LoadPackage(txtPathPackage.Text, null);
                    Package myPackage = myApplication.LoadPackage(url_packages, null);

                    // Optional set the value from one of the SSIS package variables
                    myPackage.Variables["User::file_path_import"].Value = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                                                                           + System.IO.Path.Combine(path, file_scan_directory_realtime)
                                                                           + @";Extended Properties=""Excel 8.0;HDR=YES"";";

                    // Execute package
                    var_info_log = var_info_log + "Executing package" + "\n";
                    txtShowLogs.Text = var_info_log;
                    DTSExecResult myResult = myPackage.Execute();

                    //if (myResult == Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Failure)
                    //{
                    //    foreach (Microsoft.SqlServer.Dts.Runtime.DtsError local_DtsError in myPackage.Errors)
                    //    {
                    //        MessageBox.Show(local_DtsError.Description);
                    //    }
                    //}

                    // Show the execution result
                    var_info_log = var_info_log + "Package result: " + myResult.ToString() + "\n\n";
                    var_info_log_sort = var_info_log + var_info_log_sort;
                    var_info_log = "";


                    if (myResult.ToString().ToUpper() == "Success".ToUpper())
                    {
                        string sourceFile = System.IO.Path.Combine(path, file_scan_directory_realtime);
                        string destinationFile = System.IO.Path.Combine(path, "MOVE", file_scan_directory_realtime);

                        if (System.IO.File.Exists(destinationFile))
                        {
                            System.IO.File.Delete(destinationFile);
                        }
                        // To move a file or folder to a new location:
                        System.IO.File.Move(sourceFile, destinationFile);
                    }
                    else
                    {
                        //msg error and write log file -------------------
                        string sourceFile = System.IO.Path.Combine(path, file_scan_directory_realtime);
                        string destinationFile = System.IO.Path.Combine(path, "ERROR", file_scan_directory_realtime);

                        if (System.IO.File.Exists(destinationFile))
                        {
                            System.IO.File.Delete(destinationFile);
                        }

                        // To move a file or folder to a new location:
                        System.IO.File.Move(sourceFile, destinationFile);

                        foreach (Microsoft.SqlServer.Dts.Runtime.DtsError local_DtsError in myPackage.Errors)
                        {
                            //MessageBox.Show(local_DtsError.Description);
                            var_info_log = var_info_log + "Error: " + local_DtsError.Description + "\n\n";
                            var_info_log_sort = var_info_log + var_info_log_sort;
                            var_info_log = "";
                        }
                    }

                    txtShowLogs.Text = var_info_log_sort;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer.Interval = 3000;
            timer.Start();
        }
    }
}
