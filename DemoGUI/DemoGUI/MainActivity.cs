using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;


namespace DemoGUI
{
    public partial class MainActivity : Form
    {

        private string _PathToFile;
        private string _VideoName;

        // Configurations
        private int _ConfidenceLevel;
        private int _MergeFrameNum;
        private int _MergeMeterNum;

        // python handler
        private dynamic ExtractFrameHandler;
        private dynamic AnalyzeDataHandler;
        private dynamic TextRecognitionHandler;
        private dynamic WriteToExcelHandler;

        public MainActivity()
        {
            InitializeComponent();

            // Initialize the python doucuments
            InitializePython();


        }

        private void InitializePython() {
            IPyHandler.Instance.IPyPath = "C:\\Users\\xiaole2\\Desktop\\Sources\\ExtractFrame\\Package\\IronPython\\Lib";
            string temp = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            MessageBox.Show(temp);
            Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine(Environment.CurrentDirectory);
        }

        private void OpenTool_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string name = null;
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                this._PathToFile = file;

                try
                {
                    string[] tokens = file.Split('\\');
                    name = tokens.Last();
                    this._VideoName = name;
                    if (name == this._PathToFile) {
                        try
                        {
                            tokens = file.Split('/');
                            name = tokens.Last();
                            this._VideoName = name;
                        }
                        catch { }
                    }
                    MessageBox.Show(name);

                }
                catch { }
                //MessageBox.Show(file);
  
            }
            Console.WriteLine(result); // <-- For debugging use.
            this.LabelVN.Text = "Video Name: " + this._VideoName;
            this.LabelVN.Visible = true;

        }

        private void ExitTool_Click(object sender, EventArgs e)
        {

        }

        private void ExcelTool_Click(object sender, EventArgs e)
        {

        }

        private void DatabaseTool_Click(object sender, EventArgs e)
        {

        }

        private void SearchTool_Click(object sender, EventArgs e)
        {
            string EFPyPath = @"C:\Users\xiaole2\Desktop\Sources\Application\DemoGUI\DemoGUI\ExtractFrame.py";
            dynamic EFPy = IPyHandler.Instance.setPython(EFPyPath);
            dynamic ExtractFrame = EFPy.ExtractFrame();
        }

        private void ButtonCFG_Click(object sender, EventArgs e)
        {
            string CFGmessage = "";

            if (string.IsNullOrEmpty(this.BoxCL.Text) || string.IsNullOrWhiteSpace(this.BoxCL.Text))
            {
                CFGmessage += "Please enter Confidence Level (0-100).\n";
            }
            else {
                this._ConfidenceLevel = Int32.Parse(this.BoxCL.Text);
            }

            if (string.IsNullOrEmpty(this.BoxMFN.Text) || string.IsNullOrWhiteSpace(this.BoxMFN.Text))
            {
                CFGmessage += "Please enter number of Frames want to merge.\n";
            }
            else
            {
                this._MergeFrameNum = Int32.Parse(this.BoxMFN.Text);
            }

            if (string.IsNullOrEmpty(this.BoxMMN.Text) || string.IsNullOrWhiteSpace(this.BoxMMN.Text))
            {
                CFGmessage += "Please enter number of Meters want to merge.\n";
            }
            else
            {
                this._MergeMeterNum = Int32.Parse(this.BoxMMN.Text);
            }

            if (string.IsNullOrEmpty(CFGmessage))
            {
                string CFGsuccess = "Set Successful!\nConfidence Level: {0}\nMerge Frame Num: {1}\n Merge Meter Num: {2}";
                CFGmessage = string.Format(CFGsuccess, this._ConfidenceLevel.ToString(), this._MergeFrameNum.ToString(), this._MergeMeterNum.ToString());
                MessageBox.Show(CFGmessage, "Succeed");
            }
            else {
                MessageBox.Show(CFGmessage, "Warning");
            }


        }

        private void BTNYolo_Click(object sender, EventArgs e)
        {
            BindingList<string> temp = new BindingList<string>{ "aaa", "bbb", "ccc"};
            this.showOnList(temp);
            
        }

        private void MainActivity_Load(object sender, EventArgs e)
        {

        }

        private void showOnList(BindingList<string> inputList) {
            this.ListBoxInfo.DataSource = inputList;
        }

        private void BYNAnalyze_Click(object sender, EventArgs e)
        {

            /*
            var engine = Python.CreateEngine();
            var tempPath = engine.GetSearchPaths();
            var IronPyPath = "C:\\Users\\xiaole2\\Desktop\\Sources\\ExtractFrame\\Package\\IronPython\\Lib";
            tempPath.Add(IronPyPath);
            engine.SetSearchPaths(tempPath);
            dynamic executePy = engine.ExecuteFile(@"C:\Users\xiaole2\Desktop\Sources\Application\DemoGUI\DemoGUI\Execute.py");
            dynamic execute = executePy.Execute();
            */

            string pyPath = @"C:\Users\xiaole2\Desktop\Sources\Application\DemoGUI\DemoGUI\AnalyzeData.py";
            dynamic executePy = IPyHandler.Instance.setPython(pyPath);
            dynamic AnalyzeData = executePy.AnalyzeData("", "", 0, 0);
            string tempName = AnalyzeData.__class__.__name__;
            MessageBox.Show(tempName);
        }

        private void BTNDistance_Click(object sender, EventArgs e)
        {
            //IPyHandler ipyHandler = IPyHandler.getInstance();

        }

        private void BTNAll_Click(object sender, EventArgs e)
        {

        }
    }


}
